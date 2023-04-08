namespace _1614MaximumNestingDepthoftheParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solutions = new Solution().MaxDepth("(1)+((2))+(((3)))");
            Console.WriteLine(solutions);
        }

        public class Solution
        {
            public int MaxDepth(string s)
            {
                int count = 0;
                int depth = 0;  
                   
                for(int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '(')
                    {
                        count++;
                        if (count > depth)
                            depth = count;
                    }
                    else if (s[i] == ')') { count--; }
                }
                return depth;
            }
        }
    }
}