using System;
using System.Collections.Generic;
using System.Text;

namespace Day_08
{
    static class DoubleArrayHelper
    {
        /// <summary>
        /// 获取二维数组元素
        /// </summary>
        /// <param name="array">二维数组</param>
        /// <param name="rIndex">行索引</param>
        /// <param name="cIndex">列索引</param>
        /// <param name="dir">方向</param>
        /// <param name="count">希望查找的数量</param>
        /// <returns>所有满足条件的元素</returns>
        public static string[] GetElements(String[,] array, int rIndex, int cIndex, Deriction dir, int count) 
        {
            List<string> result = new List<string>(count);
            for (int i = 0; i < count; i++)
            {
                rIndex += dir.Rindex;
                cIndex += dir.Cindex;
                if (rIndex >= 0 && rIndex < array.GetLength(0) && cIndex >= 0 && cIndex < array.GetLength(1))
                {
                    result.Add(array[rIndex, cIndex]);
                }
            }
            return result.ToArray();
        }
    }
}
