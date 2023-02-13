namespace SplitaStringinBalanceStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solutions = new Solution().BalanceStringSplit("RLRRRLLRLL");
            Console.WriteLine(solutions.ToString());
        }
    }

    public class Solution
    {
        public int BalanceStringSplit(string s)
        {
            int counter = 0;
            int points = 0;

            foreach(var chara in s)
            {
                if (chara.ToString().Equals("R")) counter++;
                else counter--;

                if(counter == 0)
                    points++;
            }
            return points;
        }
    }
}