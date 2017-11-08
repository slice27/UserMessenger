using System;
using System.Data.SQLite;
using System.Data;

namespace UserMessenger {
    class DataAccess {
        public static long InsertQuery(string connString, string query) {
            long ret = long.MinValue;
            try {
                using (SQLiteConnection sql_conn = new SQLiteConnection(connString)) {
                    sql_conn.Open();
                    SQLiteTransaction sql_trans = sql_conn.BeginTransaction();
                    using (DataSet sql_ds = new DataSet()) {
                        using (SQLiteDataAdapter sql_da = new SQLiteDataAdapter(query, sql_conn)) {
                            sql_da.Fill(sql_ds);
                        }
                    }
                    ret = sql_conn.LastInsertRowId;
                    sql_trans.Commit();
                    sql_conn.Close();
                }
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            return ret;
        }

        public static DataTable ExecuteQuery(string connString, string query) {
            DataTable ret = null;
            using (SQLiteConnection sql_conn = new SQLiteConnection(connString)) {
                sql_conn.Open();
                using (DataSet sql_ds = new DataSet()) {
                    using (SQLiteDataAdapter sql_da = new SQLiteDataAdapter(query, sql_conn)) {
                        sql_da.Fill(sql_ds);
                        if ((sql_ds.Tables.Count > 0) && (sql_ds.Tables[0].Rows.Count > 0)) {
                            ret = sql_ds.Tables[0];
                        }
                    }
                }
                sql_conn.Close();
            }
            return ret;
        }

        public string ConnectionString {
            get { return mConnString; }
            set { mConnString = value; }
        }

        public DataTable ExecuteQuery(string query) {
            return DataAccess.ExecuteQuery(mConnString, query);
        }

        public long InsertQuery(string query) {
            return DataAccess.InsertQuery(mConnString, query);
        }

        private string mConnString = string.Empty;
    }
}
