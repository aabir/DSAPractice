using System.Text;

namespace _557ReverseWordsinaString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution().ReverseWords("Let's take LeetCode contest");
            Console.WriteLine(solution);
        }

        public class Solution
        {
            public string ReverseWords(string s)
            {
                var ary = s.Split(' ');

                for (int i = 0 ; i < ary.Length; i++)
                {
                    var word = ary[i].ToArray();
                    var sb = new StringBuilder();
                    for (int j = word.Length - 1; j >= 0; j--) 
                    {
                        sb.Append(word[j]);
                    }
                    ary[i] = sb.ToString();
                }
                return string.Join(" ", ary);
            }
        }
    }
}