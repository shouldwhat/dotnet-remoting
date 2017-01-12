using System;
using System.Collections;
using System.Reflection;

namespace Controller
{
    public class UserController:MarshalByRefObject
    {
        Assembly asm = null;
        Type type = null;
        Object obj = null;
        MethodInfo method = null;

        public UserController()
        {
            asm = Assembly.Load("Service");
            type = asm.GetType("Service.UserServiceImpl");
            obj = Activator.CreateInstance(type);
        }

        public void addUser(String name, String age, String sex, String position)
        {
            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("-      Called 'addUser' Method");
            Console.WriteLine(String.Format("- name = {0}, age = {1}, sex = {2}, position = {3}", name, age, sex, position));
            Console.WriteLine("----------------------------------------------------------");

            method = type.GetMethod("addUser");

            object[] args = new object[4];
            args[0] = name;
            args[1] = age;
            args[2] = sex;
            args[3] = position;

            method.Invoke(obj, args);
        }

        public ArrayList getUser(String name)
        {
            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("-      Called 'getUser' Method");
            Console.WriteLine(String.Format("- name = {0}", name));
            Console.WriteLine("----------------------------------------------------------");

            method = type.GetMethod("getUser");

            object[] args = new object[1];
            args[0] = name;

            return (ArrayList) method.Invoke(obj, args);
        }

        public ArrayList getUserList()
        {
            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("-      Called 'getUserList' Method");
            Console.WriteLine("----------------------------------------------------------");

            method = type.GetMethod("getUserList");

            return (ArrayList) method.Invoke(obj, null);
        }
    }
}
