namespace MaximumNumberofWordsFoundInSentences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            string[] sentences = { "alice and bob love leetcode", "i think so too", "this is great thanks very much" };
            int result = program.MostWordsFound(sentences);
            Console.WriteLine(result);
        }

        public int MostWordsFound(string[] sentences)
        {
            int count = 0, max = 0;
            for (int i = 0; i < sentences.Length; i++)
            {
                count = sentences[i].Split(' ').Length;
                max = Math.Max(count, max);
            }            
            return max;
        }
    }
}