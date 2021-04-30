using System;

namespace Day_07
{
    class EnumTest
    {
        //枚举
        static void Main_Enum(string[] args)
        {
            PrintPersonStyle(PersonStyle.tall | PersonStyle.rich | PersonStyle.handsome);
            Console.WriteLine();
            PrintPersonStyle(PersonStyle.whlie | PersonStyle.rich | PersonStyle.beauty);

            //数据类型转换
            //int ==> Enum
            PersonStyle style01 = (PersonStyle)1;
            //Enum ==> int
            int style02 = (int)(PersonStyle.tall|PersonStyle.beauty);
            //string ==> Enum
            PersonStyle style03 = (PersonStyle)Enum.Parse(typeof(PersonStyle), "beauty");
            //Enum == string
            string style04 = Enum.Parse(typeof(PersonStyle), "beauty").ToString();

            //PrintPersonStyle(style);

        }
        private static void PrintPersonStyle(PersonStyle style)
        {
            if ((style & PersonStyle.tall) == PersonStyle.tall)
                Console.Write("高 ");
            if ((style & PersonStyle.whlie) == PersonStyle.whlie)
                Console.Write("白 ");
            if ((style & PersonStyle.rich) != 0)
                Console.Write("富 ");
            if ((style & PersonStyle.handsome) != 0)
                Console.Write("帅 ");
            if ((style & PersonStyle.whlie) == PersonStyle.whlie)
                Console.Write("美 ");
        }
    }
}
