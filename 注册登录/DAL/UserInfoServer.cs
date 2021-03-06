using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Models;

namespace DAL
{
    public class UserInfoServer
    {
        //【注册】确认昵称语句
        public static bool AffirmUserName(string userName)
        {
            string sql = $"select * from UserInfo where userName='{userName}'";
            SqlDataReader read = DBHelper.GetData(sql);
            if (read.Read())
            {
                read.Close();
                return true;
            }
            read.Close();
            return false;
        }

        //【注册】【登录】确认邮箱功能
        public static bool AffirmUserEmail(string Email)
        {
            string sql = $"select * from UserInfo where Email='{Email}'";
            SqlDataReader read = DBHelper.GetData(sql);
            if (read.Read())
            {
                read.Close();
                return true;
            }
            else
            {
                read.Close();
                return false;
            }
        }

        //【注册】插入语句
        public static bool InsertUser(UserInfo user)
        {
            string sql = $"insert into UserInfo(userName, Email, Account, pwd, reghitTime, state) values('{user.userName}', '{user.Email}', '{user.Email}', '{user.pwd}', '{user.reghitTime}', '{user.state}')";
            return DBHelper.Updata(sql);
        }

        //【登录】查询语句
        public static Boolean FindUser(string Email, string pwd)
        {
            string sql = $"select * from UserInfo where Email='{Email}' and pwd='{pwd}'";
            SqlDataReader read = DBHelper.GetData(sql);
            if (read.Read())
            {
                read.Close();
                return true;
            }
            read.Close();
            return false;
        }
    }
}
