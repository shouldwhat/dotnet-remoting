using Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Text;
using System.Threading.Tasks;

namespace Remoting_Client
{
    public class ConnectionBroker
    {
        private static ConnectionBroker SINGLETON = null;

        private static UserController userController = null;

        static ConnectionBroker()
        {
            if(SINGLETON == null)
            {
                SINGLETON = new ConnectionBroker();
            }
        }

        public UserController connect()
        {
            return this.createUserController();
        }

        private UserController createUserController()
        {
            HttpChannel hc = new HttpChannel();

            ChannelServices.RegisterChannel(hc, false);

            userController = Activator.GetObject(typeof(UserController), "http://192.168.1.180:10200/USERSERVICE", WellKnownObjectMode.Singleton) as UserController;

            return userController;
        }

        public static UserController getController()
        {
            return userController;
        }

        public static ConnectionBroker getInstance()
        {
            return SINGLETON;
        }
    }
}
