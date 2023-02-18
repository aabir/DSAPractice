using System.Collections.Generic;

namespace _1773CountItemsMatchingRule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IList<string>> items = new List<IList<string>> 
            { 
                new List<string> { "phone", "blue", "pixel" }, 
                new List<string> { "computer", "silver", "lenovo" }, 
                new List<string> { "phone", "gold", "iphone" } 
            };

            
            var ruleKey = "color";
            var ruleValue = "silver";
            var solution = new Solution().CountMatches(items, ruleKey, ruleValue);
            Console.WriteLine(solution);
        }
    }

    public class Solution
    {
        public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            //var dicItem = new Dictionary<string, List<string>>()
            //{
            //    {"type", new List<string>() },
            //    {"color", new List<string>() },
            //    {"name", new List<string>() }
            //};

            //foreach(List<string> item in items)
            //{
            //    dicItem["type"].Add(item[0]);
            //    dicItem["color"].Add(item[1]);
            //    dicItem["name"].Add(item[2]);
            //}

            //return dicItem[ruleKey].Count(x => string.Equals(ruleValue, x));

            int ruleKeyIndex = 0,
                counter  = 0;

            if (ruleKey == "color") ruleKeyIndex = 1;
            if (ruleKey == "name") ruleKeyIndex = 2;

            for(int i = 0; i < items.Count; i++)
            {
                if (items[i][ruleKeyIndex] == ruleValue) counter++;
            }
            return counter;
        }
    }
}