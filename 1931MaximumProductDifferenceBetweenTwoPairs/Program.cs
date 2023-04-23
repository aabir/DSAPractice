namespace _1931MaximumProductDifferenceBetweenTwoPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution().MaxProductDifference(new int[] { 5, 6, 2, 7, 4 });
            Console.WriteLine(solution);
        }

        public class Solution
        {
            public int MaxProductDifference(int[] nums)
            {
                Array.Sort(nums);
                return (nums[nums.Length - 1] * nums[nums.Length - 2]) - (nums[0] * nums[1]);
                
            }
        }
    }
}