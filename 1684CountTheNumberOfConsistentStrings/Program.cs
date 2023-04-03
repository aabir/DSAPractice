namespace _1684CountTheNumberOfConsistentStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution().CountConsistentStrings("ab", new string[] { "ad", "bd", "aaab", "baa", "badab" });
            Console.WriteLine(solution);
        }

        public class Solution
        {
            public int CountConsistentStrings(string allowed, string[] words)
            {
                int num = words.Length;

                int total = 0;

                for (int i = 0; i < words.Length; i++)
                {
                    foreach (var c in words[i].ToCharArray()) 
                    {
                        if (!allowed.Contains(c))
                        {
                            total++;
                            break;
                        }
                    }
                }
                return num - total;
            }
        }
    }
}