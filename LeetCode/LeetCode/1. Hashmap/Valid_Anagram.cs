using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._1._Hashmap
{
    internal class Valid_Anagram
    {
        public Valid_Anagram(string s, string t)
        {
            Dictionary<char, int> HashSet = new Dictionary<char, int>();

            foreach( char c in s)
            {
                if (HashSet.ContainsKey(c))
                    HashSet[c]++;
                else
                    HashSet[c] = 1;
            }

            foreach (char c in t)
            {
                if (!HashSet.ContainsKey(c))
                {
                    Console.WriteLine("False");
                    return;
                }
                HashSet[c]--;
            }

            if (HashSet.Values.All(v => v == 0))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }
    }
}
