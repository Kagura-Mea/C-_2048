using System;

namespace Day_04
{
    class Program
    {
        //递归
        private static int GetFactorial(int number)
        {
            if (number == 1) return 1;
            return number * GetFactorial(number - 1);
        }
        //递归练习
        private static int GetFactorial_01(int number)
        {
            if (number == 1) return 1;
            return GetFactorial_01(number - 1) + number * (int)Math.Pow(-1, number - 1);//Math.Pow(a,b) a的b次方

            /*if (number % 2 == 0)
                return GetFactorial_01(number - 1) - number;
            else
                return GetFactorial_01(number - 1) + number;*/
        }

        static void Main(string[] args)
        {
            //声明
            //int[] array;
            //初始化 new 数据类型[容量]
            //array = new int[6];
            //通过索引读写每个元素

            /*数组的其他写法*/
            //初始化 + 赋值
            //string[] array_01 = new string[2]{"a", "b"};
            //声明 + 初始化 + 赋值
            //bool[] array = { true, false, true };
            //float max =  GetMax(new float[] {5, 56, 465, 98});

            /*foreach (var item in collection)
            {

            }*/

            /*Console.WriteLine("请输入学生总数");
            int stuNum = int.Parse(Console.ReadLine());
            float[] array;
            array = StudentScore(stuNum);
            for (int i = 0; i < stuNum; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("数组最大值是 "+ GetMax(array));*/
        }
        //数组常用方法及属性
        private static int Array_()
        {
            int[] monthDays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            //左到右查找元素在数组中的索引值
            int arrNum = Array.IndexOf(monthDays, 31);
            //清除元素值
            //Array.Clear(monthDays, 0, monthDays.Length-1);
            //克隆
            int[] obj = (int[])monthDays.Clone();
            //排序
            Array.Sort(monthDays);
            //反转
            Array.Reverse(monthDays);

            return monthDays[11];
        }
        //成绩数组练习
        private static float[] StudentScore(int stuNum)
        {
            float[] array;
            array = new float[stuNum];
            for (int i = 0; i < stuNum;)
            {
                Console.WriteLine("请输入第 {0} 个学生成绩", i + 1);
                float stuScore = float.Parse(Console.ReadLine());
                if (stuScore >= 0 && stuScore <= 100)
                    array[i++] = stuScore;
                else
                    Console.WriteLine("输入有误");
            }
            return array;
        }
        //数组最大值
        private static float GetMax(float[] array)
        {
            float maxNum = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                maxNum = array[i] > maxNum ? array[i] : array[i];
            }
            return maxNum;
        }
        //月份数组练习
        private static int GetMonthDays(int month, int day)
        {
            int days = 0;
            int[] monthDays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            for (int i = 0; i < month; i++)
            {
                days += monthDays[i];
            }
            return days + day;
        }

        //遍历数组
        private static string GetArrayAllNumber(int[] array)
        {
            string arrayStr = "";
            foreach (int element in array)
            {
                arrayStr = arrayStr.Insert(arrayStr.Length, "  " + element);
            }
            /*for (int i = 0; i < array.Length; i++)
            {
                arrayStr = arrayStr.Insert(arrayStr.Length, "  " + array[i]);
            }*/
            return arrayStr;
        }
        
    }
}
