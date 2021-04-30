using System;
using System.Text;

namespace Day_06_Test
{
    class Program
    {
        static void Main(string[] args)
        {
/*
            //字符串常用练习
            string str = "01234567 ABC ";
            str = str.Insert(str.Length, "def");//指定位置插入
            char[] strCharArray = str.ToCharArray();//转换为char数组
            bool strBool123 = str.Contains("123");//是否含有某字符/字符串
            string strLow = str.ToLower();//大写转小写
            string strUp = str.ToUpper();//小写转大写
            int strA = str.IndexOf("A");//某字符第一次出现的位置
            string str_02 = str.Substring(2);//从指定位置截取字符串
            string str_02_06 = str.Substring(1, 6);//从指定位置到另一个指定位置截取字符串
            string strUn_ = str.Trim();//删除所有空格（TrimStart()只删除字符串的头部的空格，TrimEnd()只删除字符串尾部的空格。）
            string[] strElementArray = str.Split(" ");//用单个/多个 字符/字符串进行分割
            string strRe = str.Replace("def", "xyz");//替换
            //str.Join(separtor, array);//将字符串数组合并成一个字符串。
*/
            StringBuilder builder = new StringBuilder(20);
            builder.Append("How are you");
            WordReversal(builder);
            CharacterReverse(builder);

        }
        //单词反转
        private static void WordReversal(StringBuilder builder) 
        {
            //分成每个单词
            string[] strElementArray = builder.ToString().Split(" ");
            int j = 0;
            for (int i = strElementArray.Length - 1; i >= strElementArray.Length / 2; i--)
            {
                string temp = strElementArray[j];
                strElementArray[j] = strElementArray[i]+" ";
                strElementArray[i] = temp + " ";
                j++;
            }
            string newItem = null;
            newItem = String.Join(newItem, strElementArray);
            builder.Remove(0, builder.Length);
            builder.Append(newItem);
        }
        //字符反转
        private static void CharacterReverse(StringBuilder builder)
        {
            char[] strCharArray = builder.ToString().ToCharArray();
            int j = 0;
            for (int i = strCharArray.Length - 1; i >= strCharArray.Length / 2; i--)
            {
                char temp = strCharArray[j];
                strCharArray[j] = strCharArray[i];
                strCharArray[i] = temp;
                j++;
            }
            string newItem = null;
            newItem = String.Join(newItem, strCharArray);
            builder.Remove(0, builder.Length);
            builder.Append(newItem);
        }
        //去重
        private static void DeDuplication(string str)
        {
            StringBuilder builder = new StringBuilder(20);
            builder.Append("0123456789");
            str = builder.ToString();
        }
    }
}
