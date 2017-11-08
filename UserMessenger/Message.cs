using System;
using System.Collections.Generic;
using System.Data;

namespace UserMessenger {
    class Message {
        public static List<Message> GetMessages(UInt32 toUserId, bool getNewOnly = true) {
            List<Message> ret = new List<Message>();
            string sql = "SELECT id FROM tblMessages WHERE to_userid = {0}";
            if (getNewOnly) {
                sql += " AND received = 0";
            }
            sql += " ORDER BY sent_date DESC";
            DataTable sql_dt = DataAccess.ExecuteQuery(CONN_STRING, string.Format(sql, toUserId));
            if (sql_dt != null) {
                foreach (DataRow row in sql_dt.Rows) {
                    ret.Add(LoadMessage(Convert.ToUInt32(row["id"])));
                }
            }
            return ret;
        }

        public static Message LoadMessage(UInt32 messageId) {
            Message ret = null;
            string query = "SELECT * FROM tblMessages WHERE id = '{0}'";
            DataTable sql_dt = DataAccess.ExecuteQuery(CONN_STRING, string.Format(query, messageId));
            if (sql_dt != null) {
                DataRow sql_row = sql_dt.Rows[0];
                ret = new Message(Convert.ToUInt32(sql_row["id"]), Convert.ToUInt32(sql_row["to_userid"]),
                    Convert.ToUInt32(sql_row["from_userid"]), new DateTime(Convert.ToInt64(sql_row["sent_date"])),
                    sql_row["message"].ToString(), (Convert.ToUInt32(sql_row["received"]) == 1));
            }
            return ret;
        }

        public static Message SendMessage(UInt32 toId, UInt32 fromId, string message) {
            Message ret = null;
            int totalCount = (toId == fromId) ? 1 : 2;
            string sql = "SELECT COUNT(id) AS usercount FROM tblUsers WHERE id = {0} OR id = {1}";
            DataTable sql_dt = DataAccess.ExecuteQuery(CONN_STRING, string.Format(sql, toId, fromId));
            if (sql_dt != null) {
                DataRow sql_row = sql_dt.Rows[0];
                if (Convert.ToUInt32(sql_row["usercount"]) == totalCount) {
                    ret = new Message(0, toId, fromId, DateTime.Now, message, false);
                    ret.Save();
                }
            }
            return ret;
        }

        public static void AcknowledgeAllMessages(UInt32 toId) {
            string sql = "UPDATE tblMessages SET received = 1 WHERE to_userid = {0}";
            DataAccess.ExecuteQuery(CONN_STRING, string.Format(sql, toId));
        }

        public override string ToString() {
            string ret = string.Empty;
            User fromUser = User.LoadUser(mFromId);
            if (fromUser != null) {
                return string.Format("{0} - {1}:\r\n\t{2}", fromUser.Username, mSentDate, mMessage);
            }
            return ret;
        }

        public bool Received { get { return mReceived; } }

        private void Save() {
            string sql = "INSERT INTO tblMessages (to_userid, from_userid, sent_date, message, received) VALUES ({0}, {1}, {2}, '{3}', 0)";
            mId = (UInt32)mDa.InsertQuery(string.Format(sql, mToId, mFromId, mSentDate.Ticks, mMessage));
        }

        private Message(UInt32 id, UInt32 toId, UInt32 fromId, DateTime sent, string message, bool received) {
            mDa = new DataAccess();
            mDa.ConnectionString = CONN_STRING;
            mId = id;
            mToId = toId;
            mFromId = fromId;
            mSentDate = sent;
            mMessage = message;
            mReceived = received;
        }

        private UInt32 mId = 0;
        private UInt32 mToId = 0;
        private UInt32 mFromId = 0;
        private DateTime mSentDate = DateTime.MinValue;
        private string mMessage = string.Empty;
        private bool mReceived = false;

        private const string CONN_STRING = "DataSource=./UserMessenger.db;Version=3;New=False;Compress=True;";
        //private const string CONN_STRING = "DataSource=C:/Users/Chris/Dev/Chris/UserMessenger/UserMessenger/UserMessenger/bin/Debug/UserMessenger.db;Version=3;New=False;Compress=True;";
        private DataAccess mDa = null;
    }

}
