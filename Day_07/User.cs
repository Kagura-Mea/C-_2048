using System;
using System.Collections.Generic;
using System.Text;

namespace Day_07
{
    class User
    {
        //字段
        private string userId;
        //属性，包含两个方法
        public string UserId
        {
            get
            { return this.userId;}
            set
            { this.userId = value; } 
        }
        //自动属性，包含一个字段两个方法
        public int PassWord { get; set; }
        //构造函数
        public User() { }
        public User(string id, int pass) 
        {
            this.UserId = id;
            this.PassWord = pass;
        }
        //方法
        public void PrintUser() 
        {
            Console.WriteLine("账号：{0}    密码：{1}",UserId ,PassWord);
        }
    }
}
