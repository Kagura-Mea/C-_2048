using System;

namespace Day_02
{
    class Program
    {
        //占位符
        static void Main1(string[] args)
        {
            string gunName = "AR-15";
            string clipCapacity = "30";
            string clipBulletQuantity = "26";
            string laveBulletQuantity = "150";

            char c = '\0'; //空字符

            string str =
                string.Format("{0}: {1}/{2}   Bullet:{3}", gunName, clipBulletQuantity, clipCapacity, laveBulletQuantity);
            Console.WriteLine("c=" + c);
            Console.WriteLine(str);
            //标准数字字符串格式化
            Console.WriteLine("金额：{0:c}", 500);//￥
            Console.WriteLine("{0:d2}", 5);//不足两位用0填充
            Console.WriteLine("{0:f1}", 1.56);//根据精度显示
            Console.WriteLine("{0:p0}", 0.15);//百分比显示
            //转义符 改变字符原始含义 \" or \'
            Console.WriteLine("我爱\"Unity\"!");
            Console.WriteLine("\r\n你好，\r\n我是卢\t本\t伟");

            //源代码（.cs的文本文件）———— CLS编译 ———— 通用中间语言（exe dll）———— CLR编译 ———— 机器码
            //                         目的:跨语言                              目的：优化
            //                                                                   、跨平台
        }

        //运算符
        static void Main()
        {
            //一元运算符
            int i = 1, j = 1;
            //后加，先返回值，后自增
            Console.WriteLine("i++= {0}", i++);
            //先加，先自增，后返回值
            Console.WriteLine("++j= {0}", ++j);

            //三元运算符
            String str01 = 1 > 2 ? "yes" : "no";
            Console.WriteLine("str = {0}", str01);
        }

        //数据类型转换
        static void Main3()
        {
            //Parse转换
            string stringNumber = "11";
            int intNumString = int.Parse(stringNumber);
            float floatNumSting = float.Parse(stringNumber);

            //toString转换
            int number = 12;
            string str = number.ToString();

            //隐式转换：自动转换
            byte b1 = 255;
            int i1 = b1;
            //显示转换：强制转换
            int i2 = 256;
            byte b2 = (byte)i2;

            Console.WriteLine(b2);
        }

        //练习
        static void Main4() {
            Console.WriteLine("请输入四位数");
            string strNumber = Console.ReadLine();
            //方法1
            //int number = int.Parse(strNumber);
            //int result = number/1000+number/100%10+number/10%10+number%10;

            //方法2
            char c1000 = strNumber[0], c100 = strNumber[1], c10 = strNumber[2], c1 = strNumber[3];
            int result = int.Parse(c1000.ToString()) + int.Parse(c100.ToString()) + int.Parse(c10.ToString()) + int.Parse(c1.ToString());

            Console.WriteLine("每位相加等于：{0}", result);
        }

        //选择语句
        static void Main5()
        {
            //Console.WriteLine("你好，请输入性别：");
            //string gender = Console.ReadLine();
            //if (gender == "男")
            //{
            //    Console.WriteLine("先生请坐");
            //}
            //else if (gender == "女")
            //{
            //    Console.WriteLine("女士请坐");
            //}
            //else 
            //{
            //    Console.WriteLine("坤坤请坐");
            //}

            //Console.WriteLine("请输入第一个数字");
            //int firstNum = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入第二个数字");
            //int secondNum = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入运算符");
            //string intOperator = Console.ReadLine();

            //if (intOperator == "+") Console.WriteLine("{0} + {1} = {2}", firstNum, secondNum, firstNum + secondNum);
            //else if (intOperator == "-") Console.WriteLine("{0} - {1} = {2}", firstNum, secondNum, firstNum - secondNum);
            //else if (intOperator == "*") Console.WriteLine("{0} * {1} = {2}", firstNum, secondNum, firstNum * secondNum);
            //else if (intOperator == "/") Console.WriteLine("{0} / {1} = {2}", firstNum, secondNum, firstNum / secondNum);
            //else Console.WriteLine("请输入正确运算符");
            //不写大括号的前提是只有一句话

            /**Console.WriteLine("请输入成绩");
            int score = int.Parse(Console.ReadLine());
            if (score < 0 && score > 100) Console.WriteLine("请输入真实成绩");
            else if (score == 100) Console.WriteLine("满分！");
            else if (score >= 80) Console.WriteLine("优秀");
            else if (score >= 60) Console.WriteLine("及格");
            else if (score > 0) Console.WriteLine("还有救");
            else Console.WriteLine("没救了"); */

            //switch
            Console.WriteLine("请输入第一个数字");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个数字");
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入运算符");
            string intOperator = Console.ReadLine();
            switch (intOperator) 
            {
                case "+": 
                    Console.WriteLine("{0} + {1} = {2}", firstNum, secondNum, firstNum + secondNum);
                    break;
                case "-":
                    Console.WriteLine("{0} - {1} = {2}", firstNum, secondNum, firstNum - secondNum);
                    break;
                case "*":
                    Console.WriteLine("{0} * {1} = {2}", firstNum, secondNum, firstNum * secondNum);
                    break;
                case "/":
                    Console.WriteLine("{0} / {1} = {2}", firstNum, secondNum, firstNum / secondNum);
                    break;
                default:
                    Console.WriteLine("请输入正确运算符");
                    break;

            }

        }
    }
}
