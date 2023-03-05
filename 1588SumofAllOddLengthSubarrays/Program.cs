namespace _1588SumofAllOddLengthSubarrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2 };
            var solution = new Solution().SumOddLengthSubarrays(arr);
            Console.WriteLine(solution);
        }
    }
    public class Solution
    {
        public int SumOddLengthSubarrays(int[] arr)
        {
            int sum = 0;
            for (int i = 1; i <= arr.Length; i += 2)
            {
                for(int j = 0; j + i - 1 < arr.Length; j++)
                {
                    for(int k = j; k < j + i; k++)
                    {
                        sum += arr[k];
                    }
                }
            }
            return sum;
        }

        
    }
    
}