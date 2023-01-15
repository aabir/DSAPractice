namespace DecodeXORedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] decode = new Solution().Decode(new int[]{ 1,2,3 }, 1);

            Console.WriteLine(String.Join(",", decode));
        }

        public class Solution
        {
            public int[] Decode(int[] encoded, int first)
            {
                int[] result = new int[encoded.Length + 1];

                result[0] = first;

                for(int i = 1; i < encoded.Length+1; i++)
                {
                   result[i] = encoded[i -1] ^ result[i - 1];
                } 
                return result;
            }
        }
    }
}