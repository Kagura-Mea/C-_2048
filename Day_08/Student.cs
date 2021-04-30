using System;
using System.Collections.Generic;
using System.Text;

namespace Day_08
{
    class Student:Person
    {
        public int Score { get; set; }

        public int studenAmount;

        public static int studentNumber;

        private Random random;

        //实例构造函数：提供创建对象的方式，初始化类的实例构造成员
        //实例数据成员的工作在实例构造函数里面（养成习惯）
        public Student()
        {
            random = new Random();
            studenAmount++;
            studentNumber++;
        }
        //静态构造函数：初始化类的静态数据成员
        //类加载时调用一次
        static Student()
        {
        }
    }
}
