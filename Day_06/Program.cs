using System;
using System.Text;

namespace Day_06
{
    class Program
    {
        //string/StringBuilder
        static void Main(string[] args)
        {
            string s1 = "希儿";
            string s2 = "希儿";
            string s3 = new string(new char[] {'希', '儿'});
            //判断引用是否是同一个
            bool b1 = object.ReferenceEquals(s1, s3);
            //字符串池
            string strNum = "";
            for (int i = 0; i < 10; i++)
            {
                strNum = strNum + i.ToString();//产生很多垃圾
            }
            //可变字符串
            //StringBuilder builder = new StringBuilder();
            //一次开辟可以容纳10个字符大小的空间
            //优势：可在原有空间修改字符串
            //适用于：频繁对字符串操作
            StringBuilder builder = new StringBuilder(15);
            for (int i = 0; i < 10; i++)
            {
                builder.Append(i);
            }
            builder.Append("blyat");
            builder.Insert(0,"cyka");
            //builder.Remove();
            //builder.Replace();
            string result = builder.ToString();
        }
        static void Main1(string[] args)
        {
            //Add(1, 78, 45, 232, 456);
            //Add();

            //StackTest();
            /*int a;
            int b;*/
            //Console.WriteLine("a = " + a);
            /*RefTest(ref a);
            Console.WriteLine("a（ref） = " + a);*/
            /*OutTest(out a ,out b);
            Console.WriteLine(a + "  " + b);*/
            /*int area;
            int perimeter;
            OutTest(2, 3, out area, out perimeter);
            Console.WriteLine(area + "\t" + perimeter);*/

            //int a = 1;
            //int b = 1;
            /*string a = "123";
            string b = "123";*/
            /*int[] a = new int[] { 0 };
            int[] b = new int[] { 0 };*/
            //Console.WriteLine(a.Equals(b));



        }

        //拆装箱
        static void Main2(string[] args) 
        {
            int a = 1;
            object o = a;
            int b = (int)o;

            string str = a.ToString();//不装箱
            string str2 = a + "";//装箱
        }
        //形参object类型，实参传递值类型，则装箱
        //可以通过重载，泛型 避免
        private static void Fun(object obj)
        {
        }

        //数据类型
        //堆和栈
        private static void StackTest()
        {
            //a在栈中，1在栈中
            int a = 1;
            int b = a;
            a = 2;
            Console.WriteLine("b = " + b);

            //arr在栈中储存数组对象的引用（内存地址）
            int[] arr = new int[] { 1 };
            int[] arr_2 = arr;
            //arr[0] = 2;//修改的是堆中的数据
            arr = new int[] { 2 };//修改的是栈中储存的引用
            Console.WriteLine("arr_2[0] = " + arr_2[0]);

            string g_1 = "男";
            string g_2 = g_1;
            g_1 = "女";//修改的是栈中储存的引用
            //g_1[0] = "女";//堆中的文字，只读，不能修改
            Console.WriteLine("g_2 = " + g_2);

            //object是引用类型，o_1在栈中，1在堆中
            object o_1 = 1;
            object o_2 = o_1;
            o_1 = 2;//修改的是o_1存储的引用
            Console.WriteLine("o_2 = " + o_2);
        }

        //值参数
        private static void ValueParameterTest(ref int a) 
        {
        
        }
        //引用参数：按引用传递 -- 传递实参变量自身的内存地址
        //ref关键字
        //练习：交换数组
        private static void RefTest(ref int a, ref int b) 
        {
            int temp = a;
            a = b;
            b = temp;
        }
        //输出参数：按引用传递 -- 传递实参变量自身的内存地址
        //out关键字
        //练习：计算结果
        private static void OutTest(int length, int width ,out int area, out int perimeter)
        {
            area = length * width;
            perimeter = (length + width) * 2;
        }

        //params 参数数组
        //可以传递数组
        //可以传递一组数据类型相同的变量集合
        //可以不传递参数
        private static int Add(params int[] array)
        {
            return array[0];
        }

        //交错数组
        //每个元素都是一维数组，分布不规则
        private static void JaggedArray()
        {
            //声明
            int[][] array;
            array = new int[4][];
            //创建具有4个元素的交错数组
            array[0] = new int[5];
            array[1] = new int[6];
            array[2] = new int[3];
            array[3] = new int[2];
            //赋值
            array[0][0] = 1;
            array[0][3] = 2;
            array[1][4] = 3;
            array[2][2] = 4;
            array[2][0] = 5;
            array[3][1] = 6;
            array[3][1] = 7;
            //foreach遍历
            foreach (int[] childArray in array)
            {
                foreach (int number in childArray)
                {
                    Console.Write(number + "\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            //for循环遍历
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + "\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }


    }
}
