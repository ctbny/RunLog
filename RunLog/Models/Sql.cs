using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RunLog.Models
{
    class Sql
    {
        internal static DataTable GetDataTable(string query)
        {
            SqlConnection sqlConn = new SqlConnection("Data Source=D:/Dropbox/Visual Studio/Run Log/RunLog.sqlite");
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand(query, sqlConn);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            sqlConn.Close();
            return dt;
        }
    }
}