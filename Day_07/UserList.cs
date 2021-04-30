using System;
using System.Collections.Generic;
using System.Text;

namespace Day_07
{
    class UserList
    {
        /***********字段************/
        private User[] date = null;
        private int currentIndex;

        /***********属性************/
        public int Count { get { return currentIndex; } }

        /***********构造函数************/
        public UserList():this(5){}
        public UserList(int capacity) 
        {
            date = new User[capacity];
        }

        /***********方法************/
        //如果容量不够，就扩展一位
        private void Expansion(User[] Olderdate)
        {
            if (Olderdate[^1] != null)//在从集合末尾计算索引时，首选使用 ^ 操作符
            {
                User[] date_1 = new User[date.Length * 2];
                //Array.Copy(date, date_1, date.Length);
                date.CopyTo(date_1, 0);
                date = date_1;
            }
        }
        //增加
        public void AddElement(User value) 
        {
            Expansion(date);
            date[currentIndex++] = value;
            /*for (int i = 0; i < date.Length; i++)
            {
                if (date[i] == null) 
                {
                    date[i] = value;
                    break;
                }
            }*/
        }
        //查找
        public User GetElement(int index)
        {
            return date[index];
        }
        //插入
        public void InsertElement(int index, User value)
        {
            Expansion(this.date);
            for (int i = date.Length - 1; i >= index; i--)
            {
                date[i] = date[i - 1];
            }
            date[index - 1] = value;
        }
        //删除
        public void DeleteElement(int index)
        {
            date[index - 1] = null;
            for (int i = 0; i <date.Length - 1; i++)
            {
                date[i] = date[i + 1];
            }
            date[^1] = null;
        }
    }
}
