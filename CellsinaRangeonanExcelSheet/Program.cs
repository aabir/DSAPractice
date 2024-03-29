﻿namespace CellsinaRangeonanExcelSheet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string test = "K1:L2";
            char chars = test[0];
            //Console.WriteLine(new char test[0]);

            var cellsInRange = new Solution().CellsInRange(test);
            Console.WriteLine(String.Join(",", cellsInRange));
        }

        public class Solution
        {
            public IList<string> CellsInRange(string s)
            {
                List<string> result = new List<string>();
                for (char ch = s[0]; ch <= s[3]; ch++)
                {
                    for (char ch2 = s[1]; ch2 <= s[4]; ch2++)
                    {
                        char[] chars = { ch, ch2 };
                        result.Add(new string(chars));
                    }
                }
                return result;
            }
        }

    }
}