namespace _1859SortingtheSentence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution().SortSentence("is2 sentence4 This1 a3");
            Console.WriteLine(solution);
        }
    }

    public class Solution
    {
        public string SortSentence(string s)
        {
            string[] resultStr = new string[s.Length];

            var splitedSentence = s.Split(" ");
            for(int i = 0; i < splitedSentence.Length; i++)
            {
                int position = int.Parse(splitedSentence[i].Substring(splitedSentence[i].Length - 1));
                resultStr[position] = splitedSentence[i].Substring(0, splitedSentence[i].Length - 1);
            }
            return String.Join(" ", resultStr).Trim();
        }
    }
}