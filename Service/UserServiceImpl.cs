using Dao;
using Model;
using System;
using System.Collections;

namespace Service
{
    public class UserServiceImpl : UserService
    {
        UserDao userDao = UserDaoImpl.getInstance();

        public void addUser(String name, String age, String sex, String position)
        {
            User user = new User();

            user.Name = name;
            user.Age = age;
            user.Sex = (sex.Equals("MAIL") ? SEX.MAIL : SEX.FEMAIL);
            user.Position = (position.Equals("STAFF") ? POSITION.STAFF : position.Equals("ASSISTANT_MANAGER") ? POSITION.ASSISTANT_MANAGER : position.Equals("MANAGER") ? POSITION.MANAGER : POSITION.STAFF);

            userDao.addUser(user);
        }

        public ArrayList getUser(string name)
        {
            return userDao.getUser(name);
        }

        public ArrayList getUserList()
        {
            return userDao.getUserList();
        }
    }
}
