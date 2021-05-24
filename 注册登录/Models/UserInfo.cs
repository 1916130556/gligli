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
        public int userID { get; set; }
        public string userName { get; set; }
        public string Email { get; set; }
        public string Account { get; set; }
        public string pwd { get; set; }
        public DateTime reghitTime { get; set; }
        public string state { get; set; }
    }
}
