using System.Xml.Schema;

namespace RichestCustomerWealth01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] accounts = new int[][]
            {
                new int[] { 1, 5 },
                new int[] { 7, 3 },
                new int[] { 3, 5 }
            };

            var program = new Program();
            int result = program.MaximumWealth(accounts);
            Console.WriteLine(result);

            //Console.WriteLine(accounts[0].Length);
        }

        public int MaximumWealth(int[][] accounts)
        {
            int max = 0;
            for(int i = 0; i < accounts.Length; i++)
            {
               int sum = 0;
               for (int j = 0; j < accounts[0].Length; j++)
               {
                    sum += accounts[i][j];
               }
               max = Math.Max(max, sum);
            }
            return max;
        }
    }
}