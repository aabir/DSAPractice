using System.Globalization;

namespace _2367NumberOfArithmeticTriplets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 4, 6, 7, 10 };
            var solution = new Solution().ArithmeticTriplets(nums, 3);
            Console.WriteLine(solution);
        }
    }

    public class Solution
    {
        public int ArithmeticTriplets(int[] nums, int diff)
        {
            int result = 0;
            HashSet<int> hashSet = new HashSet<int>();

            foreach(int num in nums)
            {
                if(hashSet.Contains(num - diff) && hashSet.Contains(num - 2 * diff))
                {
                    result++;
                }
                hashSet.Add(num);
            }
            return result;
        }
    }
}