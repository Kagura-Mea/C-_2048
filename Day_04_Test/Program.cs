using System;

namespace Day_04_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //买彩票
            /*int[] yaoFale = BuyLottery();
            Console.WriteLine(GetArrayAllNumber(yaoFale));*/
            int[] yaoFale = LotteryNumber();
            //无限次兑彩票
            string str = null;
            int i = 1;
            int tf = 0;
            while (true)
            {
                int[] zuoMeng = LotteryNumber();
                //Console.WriteLine(GetArrayAllNumber(zuoMeng));
                str = Lottery(zuoMeng, yaoFale);
                //Console.WriteLine(str);
                i++;
                if (str != "未中奖")
                {
                    tf++;
                };
                Console.WriteLine(i + " : " + "中奖 {0} 次，中奖率{1}", tf, (decimal)tf / (decimal)i);
            }
            //Console.WriteLine(Lottery(new int[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 1, 2, 3, 4, 5, 6, 7 }));
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

        //彩票数组练习----买彩票
        private static int[] BuyLottery()
        {
            int[] lotteryNumber = new int[7];
            for (int i = 0; i < lotteryNumber.Length - 1;)
            {
                Console.WriteLine("请输入第 {0} 个红球号码", i + 1);
                int redNum = int.Parse(Console.ReadLine());
                if (Array.IndexOf(lotteryNumber, redNum) == -1 && redNum > 0 && redNum < 34)
                    lotteryNumber[i++] = redNum;
                else
                    Console.WriteLine("输入有误");
            }
            while (true)
            {
                Console.WriteLine("请蓝球号码");
                int blueNum = int.Parse(Console.ReadLine());
                if (blueNum > 0 && blueNum < 17)
                {
                    lotteryNumber[6] = blueNum;
                    break;
                }
                else
                    Console.WriteLine("输入有误");
            }
            return lotteryNumber;
        }
        //彩票数组练习----随机生成彩票号码
        private static int[] LotteryNumber()
        {
            int[] prizeNumber = new int[7];
            for (int i = 0; i < prizeNumber.Length - 1;)
            {
                int number = random.Next(1, 34);
                if (Array.IndexOf(prizeNumber, number) == -1)
                    prizeNumber[i++] = number;
            }
            prizeNumber[6] = random.Next(1, 17);
            Array.Sort(prizeNumber, 0, 5);
            return prizeNumber;
        }
        //判断中奖等级
        private static string Lottery(int[] lotteryNumber, int[] BuyLotteryNumber)
        {
            string win = "未中奖";
            //判断蓝球
            int winBlueNum = lotteryNumber[6] == BuyLotteryNumber[6]? 1 :0;
            //判断红球
            int winRedNum = 0;
            int[] BuyLotteryRedNumber = new int[6];
            Array.Copy(BuyLotteryNumber, BuyLotteryRedNumber, 6);
            for (int i = 0; i < lotteryNumber.Length - 1; i++)
            {
                if (Array.IndexOf(BuyLotteryRedNumber, lotteryNumber[i]) > -1)
                {
                    winRedNum++;
                }
            }
            //判断中奖等级
            switch (winRedNum, winBlueNum)
            {
                case (6, 1):
                    win = "一等奖";
                    break;
                case (6, 0):
                    win = "二等奖";
                    break;
                case (5, 1):
                    win = "三等奖";
                    break;
                case (5, 0):
                    win = "四等奖";
                    break;
                case (4, 1):
                    win = "四等奖";
                    break;
                case (4, 0):
                    win = "五等奖";
                    break;
                case (3, 1):
                    win = "五等奖";
                    break;
                case (2, 1):
                    win = "六等奖";
                    break;
                case (1, 1):
                    win = "六等奖";
                    break;
                case (0, 1):
                    win = "六等奖";
                    break;
            }
            return win;
        }
        //随机数
        static Random random = new Random();
        //草
        private static void Cao()
        {
            Console.Write("\t"); Console.Write("草"); Console.Write("\t"); Console.Write("草"); Console.WriteLine();
            for (int i = 0; i < 13; i++) Console.Write("草"); Console.WriteLine();
            Console.Write("\t"); Console.Write("草"); Console.Write("\t"); Console.Write("草"); Console.WriteLine();
            Console.WriteLine();
            Console.Write("      "); for (int i = 0; i < 7; i++) Console.Write("草"); Console.WriteLine();
            Console.Write("      "); Console.Write("草"); Console.Write("          "); Console.Write("草"); Console.WriteLine();
            Console.Write("      "); for (int i = 0; i < 7; i++) Console.Write("草"); Console.WriteLine();
            Console.Write("      "); Console.Write("草"); Console.Write("          "); Console.Write("草"); Console.WriteLine();
            Console.Write("      "); for (int i = 0; i < 7; i++) Console.Write("草"); Console.WriteLine();
            Console.Write("\t    "); Console.Write("草"); Console.WriteLine();
            for (int i = 0; i < 13; i++) Console.Write("草"); Console.WriteLine();
            Console.Write("\t    "); Console.Write("草"); Console.WriteLine();
            Console.Write("\t    "); Console.Write("草"); Console.WriteLine();
            Console.Write("\t    "); Console.Write("草"); Console.WriteLine();
        }
    }
}
