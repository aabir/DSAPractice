namespace _2006CountNumberOfPairsWithAbsoluteDifferenceK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution().CountKDifference(new int []{ 3, 2, 1, 5, 4 }, 2);
            Console.WriteLine(solution);
        }

        public class Solution
        {
            public int CountKDifference(int[] nums, int k)
            {
                if (nums.Length == 0) return 0;

                int count = 0;
                for(int i = 0; i < nums.Length; i++)
                {
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (nums[i] - nums[j] == k) count++;
                    }
                    
                }
                return count;
            }
        }
    }
}