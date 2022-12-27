namespace MinimumSumofFourDigiNumberAfterSplittingDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            var result = program.MinimumSum(2932);
            Console.WriteLine(result);
        }

        public int MinimumSum(int num)
        {
            List<int> list = new List<int>();

            while(num > 0)
            {
                int d = num % 10;
                num = num/10;
                list.Add(d);
            }

            list.Sort();
            int new1 = list[0] * 10 + list[2];
            int new2  = list[1] * 10 + list[3];

            return new1 + new2;
        }
    }
}