using System;

namespace Day_03_Test
{
    class Program
    {
        //输入年份
        static void Main(string[] args)
        {
            Console.WriteLine("请输入年份");
            YearInDecember(int.Parse(Console.ReadLine()));
            
        }
        //每年十二个月
        private static void YearInDecember(int year)
        {
            for (int month = 1; month <= 12; month++)
            {
                CurrentMonth(year, month);
                Console.WriteLine();
            }
        }
        /// <summary>
        /// 根据年月日判断星期数
        /// </summary>
        /// <param name="year">年份</param>
        /// <param name="month">月份</param>
        /// <param name="day">日期</param>
        /// <returns>星期数</returns>
        //根据日期判断星期几
        private static int GetWeekByday(int year, int month, int day)
        {
            DateTime date = new DateTime(year, month, day);
            return (int)date.DayOfWeek;
        }
        //计算指定月份的天数
        private static int GetDaysByMonth(int year, int month)
        {
            if (month > 12 || month < 0) return 0;

            switch (month)
            {
                case 2:
                    return IsLeapYear(year) ? 29 : 28;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                default:
                    return 31;
            }
        }
        //判断是否闰年,是：闰年
        private static bool IsLeapYear(int year)
        {
            return year % 400 == 0 || (year % 4 == 0 && year % 100 != 0);
        }
        //显示！！！当月日历
        private static void CurrentMonth(int year, int month)
        {
            //1.显示表头
            Console.WriteLine();
            Console.WriteLine("{0} 年 {1} 月", year, month);
            Console.WriteLine();
            Console.WriteLine("日\t一\t二\t三\t四\t五\t六\t");

            //2.第一行显示空白
            for (int week = 0; week < GetWeekByday(year, month, 1); week++)
                Console.Write("\t");

            //3.根据总天数显示日
            for (int day = 1; day <= GetDaysByMonth(year, month); day++)
            {
                Console.Write(day + "\t");
                //4.每逢周六换行
                if (GetWeekByday(year, month, day) == 6)
                    Console.WriteLine();
            }

            /*int day = 1;
            int dayWeek = GetWeekByday(year, month, day);
            //int weekNumber = WeekNumber(year, month, dayWeek);

            WeekNumber(dayWeek);

            for (int i = 0; i < 6; i++)
            {
                for (int w = 0; w < 7; w++)
                {
                    if (day <= GetDaysByMonth(year, month))
                    {
                        Console.Write("{0}\t", day);
                        if (dayWeek == 6)
                        {
                            Console.WriteLine();
                            dayWeek = 0;
                            day++;
                            continue;
                        }
                        dayWeek++;
                        day++;
                    }
                    else
                    {
                        return;
                    }
                }
            }*/

        }
    }
}
