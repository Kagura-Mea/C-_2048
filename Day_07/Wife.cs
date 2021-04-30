using System;
using System.Collections.Generic;
using System.Text;

namespace Day_07
{
    /// <summary>
    /// 定义老婆类
    /// </summary>
    class Wife
    {
        //数据成员
        //字段：存储数据
        private string name;
        //属性，保护字段  本质就是2个方法
        public string Name 
        {
            //读取时保护
            get 
            { return name; }
            //写入时保护，value：要设置的数据
            set 
            { this.name = value; }
        }
        private int age;
        public int Age { 
            get 
            {
                return age; 
            } 
            set 
            {
                if (value > 15)
                    this.age = value;
                else
                    throw new Exception("FBI,open the door !!!");
            } 
        }
        private bool sex;

        //构造函数（方法）：提供了创建对象的方式，常常用于初始化类的数据成员。
        //一个类如果没有构造函数，编译器会自动提供一个无参的构造函数

        //本质：方法
        //特点：没有返回值，与类同名，创建对象时自动调用（不能手动执行）
        //如果不希望在类外部创建对象，就将构造函数私有化
        public Wife()
        {
            Console.WriteLine("创建对象————构造函数");
        }
        public Wife(string name):this()//调用无参数构造函数
        {
            // Console.WriteLine("创建对象——无参构造");
            this.SetName(name); 
        }
        public Wife(string name, int age):this(name)//调用有参数构造函数
        {
            //this.name = name;
            if (age > 15)
                this.age = age;
            else
                throw new Exception("FBI,open the door !!!");
        }
        
        //this 对当前对象的引用： this.成员变量
        public void SetName(string name) 
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetAge(int age)
        {
            if (age >= 16)
            {
                this.age = age;
            }
            else
            {
                throw new Exception("FBI,open the door !!!");
            }
            
        }
        public int GetAge()
        {
            return age;
        }
    }
}
