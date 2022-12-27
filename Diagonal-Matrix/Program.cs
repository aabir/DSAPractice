namespace Diagonal_Matrix
{
    public class Program
    {
        static void Main()
        {
            int[,] a = 
            { 
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 } 
            };
            //PrintDiagonalSums(a, 4);

            int[] nums = { 1, 2, 3, 1, 1, 3 };
            Console.WriteLine(NumIdenticalPairs(nums).ToString());

            int NumIdenticalPairs(int[] nums)
            {
                int pairCounts = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = 1; j < nums.Length - 1; j++)
                    {
                        if ((nums[i] == nums[j]) && (nums[i] < nums[j])) pairCounts++;
                    }
                }
                return pairCounts;
            }
        }

        static void PrintDiagonalSums(int [,]matrix, int n)
        {
            int principle = 0, secondary = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(i == j)
                        principle += matrix[i, j];

                    if ((i + j) == (n -1))
                        secondary += matrix[i, j];
                }
            }
            Console.WriteLine("Principle Diagonal" + principle);
            Console.WriteLine("Secondary Diagonal" + secondary);
        }
    }
}