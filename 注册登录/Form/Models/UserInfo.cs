using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    //序列化
    [Serializable]
    public class UserInfo
    {
        //声明“字段”
        private int userID;
        private string userName;
        private string Email;
        private string Account;
        private string pwd;
        private DateTime reghitTime;

        //封装
        public int UserID { get => userID; set => userID = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Account1 { get => Account; set => Account = value; }
        public string Pwd { get => pwd; set => pwd = value; }
        public DateTime ReghitTime { get => reghitTime; set => reghitTime = value; }
    }
}
