namespace _20ValidParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.IsValid("()"));      // True
            Console.WriteLine(solution.IsValid("()[]{}"));
        }

        public class Solution
        {
            public bool IsValid(string s)
            {
                Stack<char> chars = new Stack<char>();

                Dictionary<char, char> map = new Dictionary<char, char>
                {
                    { ')', '(' },
                    { '}', '{' },
                    { ']', '[' }
                };

                foreach (char c in s)
                {
                    if (map.ContainsKey(c))
                    {
                        if (chars.Count == 0 || chars.Pop() != map[c])
                        {
                            return false;
                        }
                    }
                    else
                    {
                        chars.Push(c);
                    }
                }

                return chars.Count == 0;
            }
        }
    }
}
