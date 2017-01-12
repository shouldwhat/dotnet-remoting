using Model;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Database
{
    public class DBMS
    {
        public void addUser(User user)
        {
            userMap[user.Name] = user;
        }

        public ArrayList getUser(string name)
        {
            ArrayList list = new ArrayList();

            list.Add(userMap[name]);

            return list;
        }

        public ArrayList getUserList()
        {
            return this.dictionaryToList(userMap);
        }

        private ArrayList dictionaryToList(Dictionary<String, User> userMap)
        {
            ArrayList list = new ArrayList();

            foreach (KeyValuePair<String, User> item in userMap)
            {
                list.Add(item.Value);
            }

            return list;
        }

        private Dictionary<String, User> userMap = new Dictionary<string, User>();

        public static DBMS SINGLETON = null;

        public static DBMS getInstance()
        {
            if(SINGLETON == null)
            {
                SINGLETON = new DBMS();
            }

            return SINGLETON;
        }
    }
}
