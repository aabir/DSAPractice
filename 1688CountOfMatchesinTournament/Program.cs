namespace _1688CountOfMatchesinTournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution().NumberOfMatches(7);
            Console.WriteLine(solution);
        }

        public class Solution
        {
            public int NumberOfMatches(int n)
            {
                int count = 0;
                while(n > 1)
                {
                    if( n % 2 == 0)
                    {
                        count += n / 2;
                        n = n / 2;
                    }
                    else
                    {
                        count += (n - 1) / 2;
                        n = (n - 1) / 2 + 1;
                    }
                } 
                return count;
            }
        }
    }
}