using System;
using System.Collections.Generic;
using System.Text;

namespace Console2048
{
    /// <summary>
    /// 游戏核心算法
    /// </summary>
    class GameCore
    {
        private int[] mergeArray;
        private int[] removeZeroArray;
        private int[,] map;
        private int[,] priorMap;
        private List<Location> locationList;
        private Random random;
        public GameCore()
        {
            map = new int[4,4];
            priorMap = new int[4, 4];
            mergeArray = new int[4];
            removeZeroArray = new int[4];
            random = new Random();
            locationList = new List<Location>(16);
        }
        public bool isChange { get; set; }
        ///这里r表示Row行，c表示column列
        public void GetAllNumberFromTwoDimensional()
        {
            Console.WriteLine();
            for (int row = 0; row < map.GetLength(0); row++)
            {
                Console.Write("\t");
                for (int kind = 0; kind < map.GetLength(1); kind++)
                {
                    Console.Write(map[row, kind] + "\t");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        public void Move(MoveDirection direction)
        {
            Array.Copy(map, priorMap, map.Length);
            isChange = false;
            switch (direction)
            {
                case MoveDirection.Up:
                    Up();
                    break;
                case MoveDirection.Down:
                    Down();
                    break;
                case MoveDirection.Left:
                    Left();
                    break;
                case MoveDirection.Right:
                    Right();
                    break;
            }
            for (int r = 0; r < priorMap.GetLength(0); r++)
            {
                for (int c = 0; c < priorMap.GetLength(1); c++)
                {
                    if (priorMap[r, c] != map[r, c])
                    {
                        isChange = true;
                    }
                }
            }
        }
        private void Up()
        {
            for (int c = 0; c < map.GetLength(1); c++)
            {
                for (int r = 0; r < map.GetLength(0); r++)
                {
                    mergeArray[r] = map[r, c];
                }
                MoveAndMerge();
                for (int r = 0; r < map.GetLength(1); r++)
                {
                    map[r, c] = mergeArray[r];
                }
            }

        }
        private void Down()
        {
            for (int c = 0; c < map.GetLength(1); c++)
            {
                for (int r = map.GetLength(0) - 1; r >= 0; r--)
                {
                    mergeArray[3 - r] = map[r, c];
                }
                MoveAndMerge();
                for (int r = map.GetLength(0) - 1; r >= 0; r--)
                    map[r, c] = mergeArray[3 - r];
            }
        }
        private void Left()
        {
            for (int r = 0; r < map.GetLength(0); r++)
            {
                for (int c = 0; c < map.GetLength(1); c++)
                {
                    mergeArray[c] = map[r, c];
                }
                MoveAndMerge();
                for (int c = 0; c < map.GetLength(1); c++)
                {
                    map[r, c] = mergeArray[c];
                }
            }
        }
        private void Right()
        {
            for (int r = 0; r < map.GetLength(1); r++)
            {
                for (int c = map.GetLength(1) - 1; c >= 0; c--)
                {
                    mergeArray[3 - c] = map[r, c];
                }
                MoveAndMerge();
                for (int c = map.GetLength(1) - 1; c >= 0; c--)
                {
                    map[r, c] = mergeArray[3 - c];
                }
            }
        }
        private void RemoveZero()
        {
            Array.Clear(removeZeroArray,0,4);
            int index = 0;
            for (int i = 0; i < mergeArray.Length; i++)
            {
                if (mergeArray[i] != 0)
                    removeZeroArray[index++] = mergeArray[i];
            }
            for (int i = 0; i < removeZeroArray.Length; i++)
            {
                mergeArray[i] = removeZeroArray[i];
            }
        }
        private void MoveAndMerge()
        {
            RemoveZero();
            for (int i = 0; i < mergeArray.Length - 1;)
            {
                if (mergeArray[i] != 0 && mergeArray[i] == mergeArray[i + 1])
                {
                    mergeArray[i] = mergeArray[i] * 2;
                    mergeArray[i + 1] = 0;
                    i += 2;
                }
                i++;
            }
            RemoveZero();
        }
        private void CalculateEmpty() 
        {
            locationList.Clear();
            for (int r = 0; r < map.GetLength(0); r++)
            {
                for (int c = 0; c < map.GetLength(1); c++)
                {
                    if(map[r, c] == 0) 
                    {
                        locationList.Add(new Location(r, c));
                    }
                }
            }
        }
        public void GenerateNumber() 
        {
            CalculateEmpty();
            if (locationList.Count > 0)
            {
                int randomIndex = random.Next(0, locationList.Count);
                Location loc = locationList[randomIndex];
                map[loc.RIndex, loc.CIndex] = (random.Next(0, 10) == 0 ? 4 : 2); 
            }
        }
    }
}
