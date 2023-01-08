namespace SubtractTheProductandSumOfDigitsofanInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            Console.WriteLine(solution.SubtractProductAndSum(234));
        }
    }

    public class Solution
    {
        public int SubtractProductAndSum(int n)
        {
            List<int> listOfDigit = new List<int>();

            while (n > 0)
            {
                listOfDigit.Add(n % 10);
                n = n / 10;
            }
            int product = 1, sum = 0;
            for(int i = 0; i < listOfDigit.Count; i++)
            {
                product *= listOfDigit[i];
                sum += listOfDigit[i];
            }
            return product - sum;
        }
    }
}