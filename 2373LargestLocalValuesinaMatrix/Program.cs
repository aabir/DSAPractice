namespace _2373LargestLocalValuesinaMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] grid = new int[][] { 
                new int[] { 9, 9, 8, 1 }, 
                new int[] { 5, 6, 2, 6 }, 
                new int[] { 8, 2, 6, 4 }, 
                new int[] { 6, 2, 2, 2 } 
                };
            
            int[][] solution = new Solution().LargestLocal(grid);
            for (int i = 0; i < solution.Length; i++) 
            {
                for(int j =0; j < solution[i].Length; j++)
                {
                    Console.WriteLine(solution[i][j] + " ");
                }
            }
        }
    }
    public class Solution
    {
        public int[][] LargestLocal(int[][] grid)
        {
            int[][] res = new int[grid.Length - 2][];

            for (int i = 0; i < grid.Length - 2; i++)
            {
                res[i] = new int[grid[0].Length - 2];

                for (int j = 0; j < grid[0].Length - 2; j++)
                {
                    res[i][j] = Int32.MinValue;

                    for (int k = i; k < i + 3; k++)
                    {
                        for (int l = j; l < j + 3; l++)
                        {
                            res[i][j] = Math.Max(res[i][j], grid[k][l]);
                        }
                    }
                }
            }

            return res;
        }
    }
}