using System.Text;

namespace _804UniqueMorseCodeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution().UniqueMorseRepresentations(new string[] { "gin", "zen", "gig", "msg" });
            Console.WriteLine(solution);
        }

        public class Solution
        {
            public int UniqueMorseRepresentations(string[] words)
            {
                string[] codes = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

                StringBuilder sb = new StringBuilder();

                HashSet<string> set = new HashSet<string>();

                
                foreach (var word in words) 
                {
                    sb = new();
                    for (int i = 0; i < word.Length; i++)
                    {
                        int index = word[i] - 'a';
                        sb.Append(codes[index]);
                    }
                    set.Add(sb.ToString());
                }

                return set.Count;
                
            }
        }
    }
}