using System;

namespace Day_05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*triangle_1();
            Console.WriteLine();
            triangle_2();*/
            /*Console.WriteLine(GetArrayAllNumber(CustomSort(new int[] {1,8,1,5,5,78,12,4,65,912,46,32,5,4,56,3,3 ,-1})));
            Console.WriteLine(GetArrayAllNumber(CustomSort_2(new int[] { 1, 8, 1, 5, 5, 78, 12, 4, 65, 912, 46, 32, 5, 4, 56, 3, 3, -1 })));
            Console.WriteLine(SameElement(new int[] { 1, 8, 3, -1, -4}));*/

            GetAllNumberFromTwoDimensional(SubjectScore());

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
        //遍历二维数组
        private static void GetAllNumberFromTwoDimensional(int[,] array)
        {
            Console.WriteLine();
            Console.Write("\t");
            for (int kind = 0; kind < array.GetLength(1); kind++)
            {
                Console.Write("▼\t");
            }
            Console.WriteLine();

            for (int row = 0; row < array.GetLength(0); row++)
            {
                Console.Write(">>\t");
                for (int kind = 0; kind < array.GetLength(1); kind++)
                {
                    Console.Write(array[row, kind] + "\t");
                }
                Console.WriteLine();
            }
        }
        /*#
          ##
          ###
          ####*/
        private static void triangle_1()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
        /*####
           ###
            ##
             #*/
        private static void triangle_2()
        {
            int a = 7;
            for (int i = 0; i < a; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = a; j > i; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
        //冒泡排序
        private static int[] CustomSort(int[] array)
        {
            for (int j = 0; j < array.Length; j++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int Number = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = Number;
                    }
                }
            }
            return array;
        }
        //选择排序
        private static int[] CustomSort_2(int[] array)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                int minIndex = j;
                for (int i = j + 1; i < array.Length; i++)
                {

                    if (array[minIndex] > array[i])
                    {
                        minIndex = i;
                    }
                }
                if (minIndex != j)
                {
                    int Number = array[j];
                    array[j] = array[minIndex];
                    array[minIndex] = Number;
                }
            }
            return array;
        }
        //检查数组中是否有相同元素
        private static bool SameElement(int[] array)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = j + 1; i < array.Length; i++)
                {
                    if (array[j] == array[i]) return true;
                }
            }
            return false;
        }
        //二维数组练习
        private static int[,] SubjectScore() 
        {
            Console.WriteLine("请输入学生总数");
            int studentAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入科目总数");
            int subjectScore = int.Parse(Console.ReadLine());
            int[,] scoreArray = new int[studentAmount, subjectScore];
            for (int stu = 0; stu < scoreArray.GetLength(0); stu++)
            {
                for (int score = 0; score < scoreArray.GetLength(1); score++)
                {
                    Console.WriteLine("请输入学生 {0} 的科目 {1} 成绩", stu+1, score+1);
                    scoreArray[stu, score] = int.Parse(Console.ReadLine());
                }
            }
            return scoreArray;
        }
    }
}
