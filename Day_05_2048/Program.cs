using System;

namespace Day_05_2048
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,]
            { 
                { 4, 0 ,2 ,0 },
                { 2, 0, 2, 2 },
                { 0, 2, 0, 8 },
                { 0, 2, 2, 0 }
            };
            /*int[,] array = new int[,] { 
                { 0, 0, 0, 0 }, 
                { 0, 0, 0, 0 }, 
                { 0, 0, 0, 0 }, 
                { 0, 0, 0, 0 }
            };*/
            GetAllNumberFromTwoDimensional(array);
            Console.WriteLine("游戏开始");

            Move(array, MoveDirection.Up);
            
        }
        //移动
        private static void Move(int[,] array, MoveDirection direction)
        {
            switch (direction)
            {
                case MoveDirection.Up:
                    Up(array);
                    GetAllNumberFromTwoDimensional(array);
                    break;
                case MoveDirection.Down:
                    Down(array);
                    GetAllNumberFromTwoDimensional(array);
                    break;
                case MoveDirection.Left:
                    Left(array);
                    GetAllNumberFromTwoDimensional(array);
                    break;
                case MoveDirection.Right:
                    Right(array);
                    GetAllNumberFromTwoDimensional(array);
                    break;
                default:
                    Console.WriteLine("输入有误");
                    break;
            }
        }
        //遍历二维数组
        private static void GetAllNumberFromTwoDimensional(int[,] array)
        {
            Console.WriteLine();
            for (int row = 0; row < array.GetLength(0); row++)
            {
                Console.Write("\t");
                for (int kind = 0; kind < array.GetLength(1); kind++)
                {
                    Console.Write(array[row, kind] + "\t");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        //去零
        private static void RemoveZero(int[] array)
        {
            int[] newArray = new int[array.Length];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                    newArray[index++] = array[i];
            }
            for (int i = 0; i < newArray.Length; i++)
            {
                array[i] = newArray[i];
            }
        }
        //移动合并
        private static void MoveAndMerge(int[] row)
        {
            //去零
            RemoveZero(row);
            //合并
            for (int i = 0; i < row.Length - 1;)
            {
                if (row[i] != 0 && row[i] == row[i + 1])
                {
                    row[i] = row[i] * 2;
                    row[i + 1] = 0;
                    //统计合并位置
                    i += 2;
                }
                i++;
            }
            //去零and返回
            RemoveZero(row);
        }
        ///这里r表示Row行，c表示column列
        //四个方向移动
        private static void Up(int[,] array)
        {
            //每一列
            for (int j = 0; j < array.GetLength(1); j++)
            {
                //获取行数据，生成一维数组
                int[] row = new int[array.GetLength(0)];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    row[i] = array[i, j];
                }
                //调用移动合并方法
                MoveAndMerge(row);
                //将一维数组返回原列
                for (int i = 0; i < row.Length; i++)
                {
                    array[i, j] = row[i];
                }
            }
        }
        private static void Down(int[,] array)
        {
            //每一列
            for (int j = 0; j < array.GetLength(1); j++)
            {
                //获取行数据，生成一维数组
                int[] row = new int[array.GetLength(0)];
                for (int i = array.GetLength(0) - 1; i >= 0; i--)
                {
                    row[3 - i] = array[i, j];
                }
                //调用移动合并方法
                MoveAndMerge(row);
                //将一维数组返回原列
                for (int i = row.Length - 1; i >= 0; i--)
                    array[i, j] = row[3 - i];
            }
        }
        private static void Left(int[,] array)
        {
            //每一行
            for (int j = 0; j < array.GetLength(0); j++)
            {
                //获取列数据，生成一维数组
                int[] row = new int[array.GetLength(1)];
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    row[i] = array[j, i];
                }
                //调用移动合并方法
                MoveAndMerge(row);
                //将一维数组返回原行
                for (int i = 0; i < row.Length; i++)
                {
                    array[j, i] = row[i];
                }
            }
        }
        private static void Right(int[,] array)
        {
            //每一行
            for (int j = 0; j < array.GetLength(1); j++)
            {
                //获取列数据，生成一维数组
                int[] row = new int[array.GetLength(0)];
                for (int i = array.GetLength(0) - 1; i >= 0; i--)
                {
                    row[3 - i] = array[j, i];
                }
                //调用移动合并方法
                int u = row[1];
                MoveAndMerge(row);
                //将一维数组返回原行
                for (int i = row.Length - 1; i >= 0; i--)
                {
                    array[j, i] = row[3 - i];
                }
            }
        }
    }
}
