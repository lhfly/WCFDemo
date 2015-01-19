using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fly.WCFDemo.Contracts;
using Fly.WCFDemo.Entity;

namespace Fly.WCFDemo.Services
{
    public class UserManager : IUserManager
    {
        public List<Entity.User> GetUserList()
        {
            var list = new List<User>()
            {
                new User(){UserId = 1,UserName = "张三", PassWord = "123456"}
            };
            return list;
        }
    }
}
