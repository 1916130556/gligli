using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class UserInfoMananger
    {
        //【注册】确认昵称功能
        public static bool AffirmUserName(string userName)
        {
            return UserInfoServer.AffirmUserName(userName);
        }

        //【注册】【登录】确认邮箱功能
        public static bool AffirmUserEmail(string Email)
        {
            return UserInfoServer.AffirmUserEmail(Email);
        }

        //【注册】插入功能
        public static bool InsertUser(UserInfo user)
        {
            return UserInfoServer.InsertUser(user);
        }

        //【登录】查询功能
        public static bool FindUser(string Email, string pwd)
        {
            return UserInfoServer.FindUser(Email, pwd);
        }
    }
}
