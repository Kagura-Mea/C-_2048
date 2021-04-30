using System;

namespace Console2048
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCore core = new GameCore();
            core.GenerateNumber();
            core.GenerateNumber();
            core.GetAllNumberFromTwoDimensional();
            Console.WriteLine("游戏开始");
            while (true)
            {
                KeyDown(core);
                if (core.isChange)
                {
                    core.GenerateNumber();
                }
                core.GetAllNumberFromTwoDimensional();
            }
        }
        private static void KeyDown(GameCore core) 
        {
            switch (Console.ReadLine())
            {
                case "w":
                    core.Move(MoveDirection.Up);
                    break;
                case "s":
                    core.Move(MoveDirection.Down);
                    break;
                case "a":
                    core.Move(MoveDirection.Left);
                    break;
                case "d":
                    core.Move(MoveDirection.Right);
                    break;
                default:
                    Console.WriteLine(" The input is invalid, Please try again.");
                    break;
            }
        }
    }
}
