namespace _2315CountAsterisks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solutions = new Solution().CountAsterisks("l|*e*et|c**o|*de|");
            Console.WriteLine(solutions);
        }

        public class Solution
        {
            public int CountAsterisks(string s)
            {
                var bar = s.Split('|');
                int count = 0;

                for (int i = 0; i < bar.Length; i+=2)
                {
                    count += bar[i].Count(x => x == '*');
                }
                return count;
            }
        }
    }
}