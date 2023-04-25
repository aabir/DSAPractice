namespace _1534CountGoodTriplets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution().CountGoodTriplets(new int[] { 3, 0, 1, 1, 9, 7 }, 7, 2, 3);
            Console.WriteLine(solution);
        }

        public class Solution
        {
            public int CountGoodTriplets(int[] arr, int a, int b, int c)
            {
                int count = 0;

                for(int i = 0; i < arr.Length - 2; i++)
                {
                    for (int j = i + 1; j < arr.Length - 1; j++)
                    {
                        for (int k = j + 1; k < arr.Length; k++)
                        {
                            if (
                                Math.Abs(arr[i] - arr[j]) <= a &&
                                Math.Abs(arr[j] - arr[k]) <= b &&
                                Math.Abs(arr[i] - arr[k]) <= c
                               )
                            {
                                count++;
                            }
                        }
                    }
                }
                return count;
            }
        }
    }
}