namespace HowManyNumbersAreSmallerThantheCurrentNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Program().SmallerNumbersThanCurrent(new int[] { 8,1,2,2,3 });
            Console.WriteLine(solution.ToString());
        }

        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                int counter = 0;

                // Foreach is faster.
                foreach (int item in nums)
                {
                    if (item < nums[i]) counter++;
                }
                //for(int j = 0; j < nums.Length; j++)
                //{
                //    if(nums[j] < nums[i]) counter++;
                //}
                result[i] = counter;
            }
            return result;
        }
    }
}