using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fly.WCFDemo.Test.ServiceReference2;

namespace Fly.WCFDemo.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference2.UserManagerClient userManagerClient = new ServiceReference2.UserManagerClient();
            var list = userManagerClient.GetUserList();
            foreach (var user in list)
            {
                Console.WriteLine(user.UserId + " - " + user.UserName);
            }

            Console.ReadKey();
        }
    }
}
