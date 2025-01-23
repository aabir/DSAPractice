namespace _01TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15};
            int target = 9;
            var solution = new Solution().TwoSum(nums, target);

            Console.WriteLine($"{solution[0]} - {solution[1]}" );
        }

        public class Solution
        {
            public int[] TwoSum(int[] nums, int target)
            {
                var numToIndex = new Dictionary<int, int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    int complement = target - nums[i];
                    if (numToIndex.ContainsKey(complement))
                    {
                        return [numToIndex[target - nums[i]], i];
                    }
                    numToIndex[nums[i]] = i;
                }
                return new int[0];
            }
        }
    }
}
