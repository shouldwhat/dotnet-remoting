using Model;
using System;
using System.Collections;

namespace Dao
{
    public interface UserDao
    {
        ArrayList getUserList();

        ArrayList getUser(String name);

        void addUser(User user);
    }
}
