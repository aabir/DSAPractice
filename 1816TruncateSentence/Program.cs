namespace _1816TruncateSentence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution().TruncateSentence("Hello how are you Contestant", 4);
            Console.WriteLine(solution);
        }

        public class Solution
        {
            public string TruncateSentence(string s, int k)
            {
                if (s == null || s == string.Empty) return s;

                var splittedString = s.Split(' ');
                int extraStr = splittedString.Length - k;
                if(extraStr > 0) { splittedString = splittedString.Take(splittedString.Length - extraStr).ToArray();  }

                return string.Join(" ", splittedString);

                
            }
        }
    }
}