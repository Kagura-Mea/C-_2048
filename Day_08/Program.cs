using System;

namespace Day_08
{
    class Program
    {
        static void Main_Inherit(string[] args)
        {
            //子类可以使用父类成员
            Student student = new Student();
            student.Name = "jk";
            //父类型引用指向子类对象
            //只能使用父类成员
            Person person = new Student();
            //使用子类成员，强转
            Student student_1 = (Student)person;
            //强转失败，不会抛出异常
            Teacher teacher = person as Teacher;
            if (teacher != null)
            {
                teacher.wage = 100;
            }
            //teacher.wage = 100;//.NullReferenceException：实例为NULL
        }
        //static 关键字
        static void MainStatic()
        {
            Student student_1;//类被加载 静态数据成员存在
            student_1 = new Student();
            Student student_2 = new Student();
            Student student_3 = new Student();
            Student student_4 = new Student();

            //通过引用 调用
            Console.WriteLine(student_4.studenAmount);
            //通过类名 调用
            Console.WriteLine(Student.studentNumber);
        }
        //需求：在二维数组中获取某个元素像某一个方向上的元素
        static void Main_DoubleArray()
        {
            string[,] array = new string[5, 6];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = i.ToString() + j.ToString();
                }
            }
            string[] strArr = DoubleArrayHelper.GetElements(array, 5, 3, Deriction.Up, 6);
        }
        //结构体 :与类语法相似，都可以包含数据成员和方法成员，但结构属于值类型（类属于引用类型）
        static void Main()
        {
            DerictionStruct derictionStruct = new DerictionStruct();
        }
    }
}
