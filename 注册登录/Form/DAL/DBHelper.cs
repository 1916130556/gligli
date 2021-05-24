using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBHelper
    {
        //public static string connStr = @"server=LAPTOP-RSHOJC20; initial catalog=Giligli; Integrated Security=true";
        public static string connStr = @"server=LAPTOP-RSHOJC20; database=Gligli; uid=sa; pwd=123";
        public static SqlConnection conn;

        public static void Open()
        {
            if (conn == null)
                conn = new SqlConnection(connStr);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            //如果连接中断，则重启连接
            if (conn.State == ConnectionState.Broken)
            {
                conn.Close();
                conn.Open();
            }
        }
        public static void Close()
        {
            if (conn==null)
                return;
            if (conn.State == ConnectionState.Open)
                conn.Close();       
        }
        ////非断开式连接，查询语句
        public static SqlDataReader GetData(string sql)
        {
            Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            return cmd.ExecuteReader();
        }

        //断开式连接
        public static DataSet GetDataSet(string sql)
        {
            Open();
            DataSet ds = new DataSet();
            SqlDataAdapter asd = new SqlDataAdapter(sql, conn);
            asd.Fill(ds);
            Close();
            return ds;
        }

        //增删改查
        public static bool Updata(string sql)
        {
            Open();
            SqlCommand cmd = new SqlCommand(sql,conn); 
            return cmd.ExecuteNonQuery()>0;
        }
    }
}
