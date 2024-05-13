using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._1._Hashmap
{
    internal class MainHashMap
    {
        public MainHashMap()
        {
            TopK k = new TopK();
            var res = k.TopKFrequent(new[] { 1, 1, 1, 2, 2, 3 }, 2);

            Console.WriteLine("TopKFrequent");
            Console.WriteLine(string.Join(",", res));


            Group_Anagram v = new Group_Anagram();
            var x = v.GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });
            v.LINQ();
        }
    }
}
