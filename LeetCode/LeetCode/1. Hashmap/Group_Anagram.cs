using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._1._Hashmap
{
    public class Group_Anagram
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            string combined = String.Join(", ", strs);
            Console.WriteLine("Group Anagram : {0}", combined);
            Dictionary<string, IList<string>> group = new Dictionary<string, IList<string>>();

            foreach (string s in strs) 
            {
                char[] hash = new char[26];
                foreach(char c in s) 
                {
                    hash[c - 'a']++;
                }

                string key = new string(hash);
                if(!group.ContainsKey(key))
                    group[key] = new List<string>();
                group[key].Add(s);
            }
            return group.Values.ToList();
        }

        public void LINQ()
        {
            string[] words = { "eat", "tea", "tan", "ate", "nat", "bat" };

            var groupedAnagrams = words.GroupBy(w => String.Concat(w.OrderBy(c => c)));

            foreach (var group in groupedAnagrams)
            {
                Console.WriteLine($"Anagrams of {group.Key}: {string.Join(", ", group)}");
            }
        }
    }
}
