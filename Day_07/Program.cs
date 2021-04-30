using System;
using System.Collections.Generic;
using System.Text;

namespace Day_07
{
    class Program
    {
        static void MainWife() 
        {
            //声明Wife类型的引用
            Wife wife_1;
            //指向Wife类型的对象（实例化）
            wife_1 = new Wife();
            wife_1.SetName("UMP45");
            wife_1.SetAge(16);

            Console.WriteLine(wife_1.GetName());
            Console.WriteLine(wife_1.GetAge());

            Wife wife_2 = new Wife();
            wife_2.Name = "Tac50";
            wife_2.Age = 17;
            Console.WriteLine(wife_2.Name);
            Console.WriteLine(wife_2.Age);

            Wife wife_3 = new Wife("qbz95", 26);
            Console.WriteLine(wife_3.Name);
            Console.WriteLine(wife_3.Age);

            Wife wife_4 = new Wife("01", 23);
            Wife wife_5 = new Wife("34", 20);
            Wife wife_6 = new Wife("03", 19);
            Wife wife_7 = new Wife("04", 28);
            Wife wife_8 = new Wife("05", 36);
            Wife wife_9 = new Wife("06", 40);

            Wife[] wifeArray = new Wife[] { wife_1, wife_2, wife_3, wife_4, wife_5, wife_6, wife_7, wife_8, wife_9 };

            Console.WriteLine("young : " + GetYoungestWife(wifeArray).Name);
        }
        static void MainUserList() 
        {
            User user1 = new User("1aaa", 123456);
            User user2 = new User("2bbb", 234567);
            User user3 = new User("3ccc", 345678);
            User user4 = new User("4ddd", 456789);
            User user5 = new User("5eee", 567890);
            User user6 = new User("6fff", 678901);

            UserList userList = new UserList();
            userList.AddElement(user1);
            userList.AddElement(user2);
            userList.AddElement(user3);
            userList.AddElement(user4);
            userList.AddElement(user5);

            for (int i = 0; i < userList.Count; i++)
            {
                userList.GetElement(i).PrintUser();
            }

            userList.InsertElement(3, user6);

            userList.DeleteElement(1);

            
        }
        //C#集合 <泛型>      List<数据类型> 
        static void MainList() 
        {
            //List<数据类型> 
            List<User> userList = new List<User>();
            User user1 = new User("1aaa", 123456);
            User user2 = new User("2bbb", 234567);
            User user3 = new User("3ccc", 345678);
            userList.Add(user1);
            userList.Add(user2);
            userList.Add(user3);
            userList.Add(user2);
            //userList.Remove(user2);
            User user4 = userList[1];
            for (int i = 0; i < userList.Count; i++)
            {
                userList[i].PrintUser();
            }
        }
        //字典集合，根据？查找？（键值对）
        static void Main() 
        {
            Dictionary<string, User> user = new Dictionary<string, User>();
            user.Add("a1", new User("User_a1", 11111));
            User user_0 = user["a1"];
        }
        //找出年龄最小的对象
        private static Wife GetYoungestWife(Wife[] wifeArray) 
        {
            Wife GetYoungestWife = wifeArray[0];
            for (int i = 1; i < wifeArray.Length; i++)
            {
                if (wifeArray[i].Age < GetYoungestWife.Age)
                {
                    GetYoungestWife = wifeArray[i];
                }
            }
            return GetYoungestWife;
        }
    }
}
