using Dao;
using Model;
using System;
using System.Collections;

namespace Service
{
    public interface UserService
    {
        ArrayList getUserList();

        ArrayList getUser(String name);

        void addUser(String name, String age, String sex, String position);
    }
}
