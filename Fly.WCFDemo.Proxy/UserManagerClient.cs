using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Fly.WCFDemo.Contracts;
using Fly.WCFDemo.Entity;

namespace Fly.WCFDemo.Proxy
{
    public class UserManagerClient : ClientBase<IUserManager>, IUserManager
    {
        public UserManagerClient()
        {
        }

        public UserManagerClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public UserManagerClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public UserManagerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public UserManagerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        public List<User> GetUserList()
        {
            return base.Channel.GetUserList();
        }

    }
}
