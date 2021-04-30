using System;

namespace SolutionBase
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //Console.WriteLine("Your Name:");
            //string input = Console.ReadLine();
            //Console.WriteLine("Your Name is " + input);
            //Console.ReadLine();

            //float num01 = 3.0f;
            //float num02 = 2.9f;
            //float result = num01 - num02; //result=0.0999999999
            //bool or = result == 0.1f;
            //Console.WriteLine(or);
            //Console.ReadLine();


            //decimal num01 = 3.0m;
            //decimal num02 = 2.9m;
            //decimal result = num01 - num02;
            //bool or = result == 0.1m;
            //Console.WriteLine(or);
            //Console.ReadLine();

            Console.WriteLine("请输入枪的名称");
            string gunName = Console.ReadLine();
            Console.WriteLine("请输入弹夹容量");
            string clipCapacity = Console.ReadLine();
            Console.WriteLine("请输入当前弹夹内子弹数量");
            string clipBulletQuantity = Console.ReadLine();
            Console.WriteLine("请输入剩余子弹数量");
            string laveBulletQuantity = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(gunName + "：");
            Console.WriteLine(clipBulletQuantity + "/" + clipCapacity);
            Console.WriteLine("Bullet:" + laveBulletQuantity);
            Console.ReadLine();
        }
    }
}
