namespace _2037MinimumNumberofMovestoSeatEveryone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solutions = new Solution().MinMovesToSeat(new int[] { 3, 1, 5 }, new int[] { 2, 7, 4 });
            Console.WriteLine(solutions);
        }

        public class Solution
        {
            public int MinMovesToSeat(int[] seats, int[] students)
            {
                Array.Sort(seats);
                Array.Sort(students);

                int count = 0;

                for(int i = 0; i < seats.Length; i++)
                {
                    count += Math.Abs(seats[i] - students[i]);
                }
                return count;
            }
        }
    }
}