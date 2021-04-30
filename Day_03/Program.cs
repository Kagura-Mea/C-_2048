using System;

namespace Day_03
{
    class Program
    {
        //for循环
        static void Main1(string[] args)
        {
            float j = 0.01f;
            for (int i = 1; i<=30 ; i++){
                j *= 2;
                Console.WriteLine("第 {0} 次对折，厚度为{1}毫米",i, j);
                //continue 结束本次循环继续下次循环
            }

        }
        //while循环
        static void Main2(string[] args) 
        {
            float bor = 100.0f;
            int i = 0;
            float result = bor;
            while (bor / 2 >= 0.01)
            {
                i++;
                bor /= 2;
                result += bor * 2;
                Console.WriteLine("第 {0} 次弹起，弹起高度为 {1} M，共经过 {2} M", i, bor, result);
                //break 结束循环;
            }
        }
        //do while循环
        //随机数Random
        static void Main3(string[] args) {
            //生产随机数
            Random randem = new Random();
            int number = randem.Next(1, 101);
            Console.WriteLine("已生成随机数，请猜测【1---100】【{0}】", number);
            
            int guessNumber = 0;
            int i = 0;

            do {
                i++;
                guessNumber = int.Parse(Console.ReadLine());
                if (guessNumber > number)
                    Console.WriteLine("大了，猜了{0}次", i);
                else if (guessNumber < number)
                    Console.WriteLine("小了，猜了{0}次", i);
                else
                    Console.WriteLine("恭喜猜对，猜了{0}次", i);
            } while (guessNumber != number);
        }

        /**定义方法
        返回值
        【一个】方法，【一个】功能
        方法调用 */
    }
    class Test 
    {
        
    }
}
