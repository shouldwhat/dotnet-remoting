using Database;
using Model;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Dao
{
    public class UserDaoImpl : UserDao
    {
        DBMS dbms = DBMS.getInstance();

        public void addUser(User user)
        {
            dbms.addUser(user);
        }

        public ArrayList getUser(string name)
        {
            return dbms.getUser(name);
        }

        public ArrayList getUserList()
        {
            return dbms.getUserList();
        }

        private Dictionary<String, User> userMap = new Dictionary<string, User>();

        public static UserDaoImpl SINGLETON = null;

        public static UserDaoImpl getInstance()
        {
            if(SINGLETON == null)
            {
                SINGLETON = new UserDaoImpl();
            }

            return SINGLETON;
        }
    }
}
