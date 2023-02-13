namespace CounttheDigitsThatDivideaNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution().CountDigits(121);
            Console.WriteLine(solution);
        }
    }

    public class Solution
    {
        public int CountDigits(int num)
        {
            int result = 0;
            int temNum = num;

            while (temNum > 0)
            {
                int k = temNum % 10;
                temNum /= 10;

                if(num % k == 0) result++;
            }
            return result;
           
        }
    }

}