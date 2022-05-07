using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DataHandle
{
    public class HandleCLS
    {
        public static string tempVal;
        public static SqlConnection conn(string nameServer, string nameDatabase)
        {
            string query = String.Format(@"Server={0};Database={1};Integrated Security=true", nameServer, nameDatabase);
            return new SqlConnection(query);
        }
        public static DataTable freedomAdap(string query, SqlConnection conn)
        {
            SqlDataAdapter adap = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public static DataTable selectData(string tableName, SqlConnection conn)
        {
            string query = String.Format("SELECT * FROM {0}", tableName);
            SqlDataAdapter adap = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public static DataTable selectData(string tableName, string idname, object idval, SqlConnection conn)
        {
            try{ Convert.ToInt32(idval); }
            catch{ idval = "'" + idval + "'"; }
            string query = String.Format("SELECT * FROM {0} WHERE {1}={2}", tableName, idname, idval);
            SqlDataAdapter adap = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public static bool insertData(string tableName, Dictionary<string, object> dataIn, SqlConnection conn)
        {
            bool result = false;
            string key = "", value = "";
            foreach (var data in dataIn)
            {
                key += data.Key + ",";
                try
                {
                    value += Convert.ToInt32(data.Value) + ",";
                }
                catch { value += "N'" + data.Value + "'" + ","; }
            }
            key = key.Substring(0, key.Length - 1);
            value = value.Substring(0, value.Length - 1);
            string query = String.Format("INSERT INTO {0}({1}) VALUES({2})", tableName, key, value);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Connection.Open();
            result = (cmd.ExecuteNonQuery() > 0);
            cmd.Connection.Close();
            return result;
        }
        public static bool updateData(string tableName, Dictionary<string, object> dataUp, string idName, object idVal, SqlConnection conn)
        {
            try { Convert.ToInt32(idVal); }
            catch { idVal = "'" + idVal + "'"; }
            bool result = false;
            string upVal = "";
            foreach (var data in dataUp)
            {
                try
                {
                    upVal += String.Format("{0}={1},", data.Key, Convert.ToInt32(data.Value));
                }
                catch { upVal += String.Format("{0}={1},", data.Key, data.Value); }
            }
            upVal = upVal.Substring(0, upVal.Length - 1);
            string query = String.Format("UPDATE {0} SET {1} WHERE {2}={3}", tableName, upVal, idName, idVal);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Connection.Open();
            result = (cmd.ExecuteNonQuery() > 0);
            cmd.Connection.Close();
            return result;
        }
        public static bool deleteData(string tableName, string idName, object idVal, SqlConnection conn)
        {
            try { Convert.ToInt32(idVal); }
            catch { idVal = "'" + idVal + "'"; }
            bool result = false;
            string query = String.Format("DELETE FROM {0} WHERE {1}={2}", tableName, idName, idVal);
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Connection.Open();
            result = (cmd.ExecuteNonQuery() > 0);
            cmd.Connection.Close();
            return result;
        }
       
    }
}
