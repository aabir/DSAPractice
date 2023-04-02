namespace _2220MinimumBitFlipsToConvertNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution().MinBitFlips(10, 7);
            Console.WriteLine(solution);
        }

        public class Solution
        {
            public int MinBitFlips(int start, int goal)
            {
                int result = start ^ goal;
                int output = 0;
                while (result != 0) 
                {
                    if ((result & 1) == 1) { output++; }
                    result = result >> 1;
                }
                return output;
            }
        }
    }
}