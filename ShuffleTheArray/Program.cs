namespace ShuffleTheArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 5, 1, 3, 4, 7 };
            int n = 3;
            var prgoram = new Program();
            int[] result = prgoram.Shuffle(nums, n);
            Console.WriteLine(result);
        }

        public int[] Shuffle(int[] nums, int n)
        {
            int[] result = new int[nums.Length];

            for (int i = 0, j = 0; i < n; i++, j += 2)
            {
                result[j] = nums[i];
                result[j + 1] = nums[i + n];
            }
            return result;
        }
    }
}