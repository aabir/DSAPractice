namespace CreateTargetArrayintheGivenOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 0, 1, 2, 3, 4 };
            int[] index = new int[] { 0, 1, 2, 2, 1 };

            var targetAry = new Solution().CreateTargetArray(nums, index);
            Console.WriteLine(string.Join(",", targetAry));
        }
    }
    public class Solution
    {
        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            List<int> target = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                target.Insert(index[i], nums[i]);
            }
            return target.ToArray();
        }
    }
}