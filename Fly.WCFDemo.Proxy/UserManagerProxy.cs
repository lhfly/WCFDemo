using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fly.WCFDemo.Entity;

namespace Fly.WCFDemo.Proxy
{
    public class UserManagerProxy
    {
        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <returns></returns>
        public static List<User> GetUserList()
        {
            var list = new UserManagerClient().GetUserList();
            return list;
        }
    }
}
