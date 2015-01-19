using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Fly.WCFDemo.Entity;

namespace Fly.WCFDemo.Contracts
{
    [ServiceContract]
    public interface IUserManager
    {
        [OperationContract]
        List<User> GetUserList();
    }
}
