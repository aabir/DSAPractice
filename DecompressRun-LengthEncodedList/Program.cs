namespace DecompressRun_LengthEncodedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var decomporessList = new Solution().DecompressRLElist(new int[] { 1, 1, 2, 3 });
            Console.WriteLine(String.Join(",", decomporessList));
        }

        public class Solution
        {
            public int[] DecompressRLElist(int[] nums)
            {
                List<int> result = new List<int>();
                for(int i = 0; i < nums.Length-1; i += 2)
                {
                    int count = nums[i];
                    int numbers = nums[i+1];
                    for(int j = 0; j < count; j++)
                    {
                        result.Add(numbers);
                    }
                }
                return result.ToArray();
            }
        }
}

    
        
      
}