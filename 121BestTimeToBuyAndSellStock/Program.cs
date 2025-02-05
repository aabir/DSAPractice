namespace _121BestTimeToBuyAndSellStock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] price1 = { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine(solution.MaxProfit(price1));
        }
    }

    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int minPrice = int.MaxValue;
            int maxProfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                else if (prices[i] - minPrice > maxProfit)
                {
                    maxProfit = prices[i] - minPrice;
                }
            }

            return maxProfit;
        }
    }
}
