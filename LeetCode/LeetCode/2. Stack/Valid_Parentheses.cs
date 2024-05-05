using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._2._Stack
{
    public class Valid_Parentheses
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> hashmap = new Dictionary<char, char>();
            hashmap[')'] = '(';
            hashmap['}'] = '{';
            hashmap[']'] = '[';
            
            foreach(char c in s) 
            {
                if (hashmap.ContainsKey(c))
                {
                    char result = stack.Pop();
                    if (hashmap[c] != result)
                        return false;
                }
                stack.Push(c);
            }
            return stack.Count == 0;

        }
    }
}
