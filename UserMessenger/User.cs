using System;
using System.Data;
using System.Collections.Generic;
using System.Security.Principal;

namespace UserMessenger {
    public class User {
        public static List<User> GetUsers() {
            // Get a list of all the users that aren't deleted.
            List<User> ret = new List<User>();
            string query = "SELECT user_sid FROM tblUsers WHERE deleted = 0";
            DataTable sql_dt = DataAccess.ExecuteQuery(CONN_STRING, query);
            if (sql_dt != null) {
                foreach(DataRow row in sql_dt.Rows) {
                    ret.Add(LoadUser(row["user_sid"].ToString()));
                }
            }
            return ret;
        }

        public static User LoadUser(string sid) {
            string query = string.Format("SELECT * FROM tblUsers WHERE user_sid = '{0}'", sid);
            return LoadUserByQuery(query);
        }

        public static User LoadUser(UInt32 id) {
            string query = string.Format("SELECT * FROM tblUsers where id = '{0}'", id);
            return LoadUserByQuery(query);
        }

        private static User LoadUserByQuery(string query) {
            User ret = null;
            DataTable sql_dt = DataAccess.ExecuteQuery(CONN_STRING, query);
            if (sql_dt != null) {
                DataRow sql_row = sql_dt.Rows[0];
                ret = new User(Convert.ToUInt32(sql_row["id"]), sql_row["username"].ToString(),
                    sql_row["user_sid"].ToString(), (Convert.ToUInt32(sql_row["deleted"]) == 1), true);
            }
            return ret;
        }

        public static User LoadCurrentUser() {
            WindowsIdentity user = WindowsIdentity.GetCurrent();
            SecurityIdentifier sid = user.User;
            User aUser = LoadUser(sid.ToString());
            if (aUser != null) {
                if (aUser.mUsername != Environment.UserName) {
                    // The user has changed their username since last login, save it to the database.
                    aUser.Save();
                }
            } else {
                aUser = new User(0, Environment.UserName, sid.ToString(), false, false);
            }
            return aUser;
        }

        public static void RegisterUser(string username, string sid) {
            string checkQuery = "SELECT id FROM tblUsers WHERE user_sid = '{0}'";
            DataTable sql_dt = DataAccess.ExecuteQuery(CONN_STRING, string.Format(checkQuery, sid));
            if (sql_dt != null) {
                // User exists, just update the deleted field.
                string updateUser = "UPDATE tblUsers SET deleted = 0 WHERE user_sid = '{0}'";
                DataAccess.ExecuteQuery(CONN_STRING, string.Format(updateUser, sid));
            } else {
                string createUser = "INSERT INTO tblUsers (username, user_sid, deleted) VALUES ('{0}', '{1}', 0)";
                DataAccess.ExecuteQuery(CONN_STRING, string.Format(createUser, username, sid));
            }
        }

        public static void UnregisterUser(string sid) {
            string query = "UPDATE tblUsers SET deleted = 1 WHERE user_sid = '{0}'";
            DataAccess.ExecuteQuery(CONN_STRING, string.Format(query, sid));
        }

        public static void UnregisterUser(User aUser) {
            UnregisterUser(aUser.mSid);
        }

        public static User AddUser(string username, string sid, bool registered) {
            User ret = new User(0, username, sid, !registered, false);
            ret.Save();
            return ret;
        }



        public UInt32 Id { get { return mId; } }
        public string Username { get { return mUsername; } }

        public override string ToString() {
            return mUsername;
        }

        public bool IsRegistered() {
            return (!mDeleted && mExists);
        }

        public void RegisterUser() {
            mDeleted = false;
            Save();
        }

        public void UnregisterUser() {
            mDeleted = true;
            Save();
        }

        public void Save() {
            if (mExists) {
                // Update the user.
                string sql = "UPDATE tblUsers SET username = '{0}', deleted = {2} WHERE user_sid = '{1}'";
                mDa.ExecuteQuery(string.Format(sql, mUsername, mSid, (mDeleted ? 1 : 0)));
            } else {
                string sql = "INSERT INTO tblUsers (username, user_sid, deleted) VALUES ('{0}', '{1}', {2})";
                mId = (UInt32)mDa.InsertQuery(string.Format(sql, mUsername, mSid, (mDeleted ? 1 : 0)));
            }
            
            mExists = true;
        }

        private User(UInt32 id, string username, string sid, bool deleted, bool exists) {
            mId = id;
            mUsername = username;
            mSid = sid;
            mDeleted = deleted;
            mExists = exists;
            mDa = new DataAccess();
            mDa.ConnectionString = CONN_STRING;
        }

        

        private const string CONN_STRING = "DataSource=UserMessenger.db;Version=3;New=False;Compress=True;";
        //private const string CONN_STRING = "DataSource=C:/Users/Chris/Dev/Chris/UserMessenger/UserMessenger/UserMessenger/bin/Debug/UserMessenger.db;Version=3;New=False;Compress=True;";
        private UInt32 mId = 0;
        private string mUsername = string.Empty;
        private string mSid = string.Empty;
        private bool mDeleted = false;
        private bool mExists = false;
        private DataAccess mDa = null;
    }
}
