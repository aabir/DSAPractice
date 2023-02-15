namespace _2325DecodeTheMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution().DecodeMessage("eljuxhpwnyrdgtqkviszcfmabo", "zwx hnfx lqantp mnoeius ycgk vcnjrdb");
            Console.WriteLine(sol);
        }
    }
    public class Solution
    {
        public string DecodeMessage(string key, string message)
        {
            var uniKey = key.ToCharArray().Distinct().ToArray();
            key = new string(uniKey).Replace(" ", "");
            string value = "abcdefghijklmnopqrstuvwxyz";

            string res = string.Empty;

            for(int i = 0; i <message.Length; i++)
            {
                int index = key.IndexOf(message[i]);

                if (index != -1)
                {
                    res += value[index];
                }
                else
                {
                    res += message[i];
                }
            }
            return res;
        }
    }
}