using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Fly.WCFDemo.Services;

namespace Fly.WCFDemo.Hosting
{
    class Program
    {
        static log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            log.Info("log4net已经启动");
            using (var host = new ServiceHost(typeof(UserManager)))
            {
                host.Open();
                Console.WriteLine("Service start.");
                Console.Read();
            }
        }
    }
}
