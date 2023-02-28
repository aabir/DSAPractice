namespace _1791FindCenterofStartGraph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] edges = new int[][]
            {
                new int[] {1, 2 },
                new int[] {2, 3 },
                new int[] {4, 2 }
            };
            var solution = new Solution().FindCenter(edges);
            Console.WriteLine(solution);
        }

        public class Solution
        {
            public int FindCenter(int[][] edges)
            {
                if (edges[0][0] == edges[1][0] || edges[0][0] == edges[1][1])
                {
                    return edges[0][0];
                }
                else { return edges[0][1]; }
            }
        }
    }
}