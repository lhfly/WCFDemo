using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fly.WCFDemo.Proxy;

namespace Fly.WCFDemo.Test2
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = UserManagerProxy.GetUserList();
            foreach (var user in list)
            {
                Console.WriteLine(user.UserId + " - " + user.UserName);
            }

            Console.ReadKey();
        }
    }
}
