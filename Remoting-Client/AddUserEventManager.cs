using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remoting_Client
{
    public delegate void AddUserEvent(AddUserEventArgs args);
    public class AddUserEventManager
    {
        public static AddUserEventManager SINGLETON = null;
        public event AddUserEvent addUserEventHandler = null;

        static AddUserEventManager()
        {
            if(SINGLETON == null)
            {
                SINGLETON = new AddUserEventManager();
            }
        }

        public void onAddUserEvent(AddUserEventArgs args)
        {
            if(addUserEventHandler != null)
            {
                addUserEventHandler(args);
            }
        }
    }
}
