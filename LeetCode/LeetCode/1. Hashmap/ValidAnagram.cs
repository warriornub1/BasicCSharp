using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._1._Hashmap
{
    internal class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            Console.WriteLine("Valid Anagram : {0} and {1}", s, t);
            if (s.Length != t.Length) 
                return false;

            Dictionary<char, int> dic = new Dictionary<char, int>();
            Dictionary<char, int> dic1 = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                dic[s[i]] = dic.ContainsKey(s[i]) ? dic[s[i]] + 1 : 1;
                dic1[t[i]] = dic1.ContainsKey(t[i]) ? dic1[t[i]] + 1 : 1;

            }

            foreach(char c in dic.Keys)
            {
                if (!dic1.ContainsKey(c) || dic[c] != dic1[c])
                    return false;
            }
            return true;

        }
    }
}
