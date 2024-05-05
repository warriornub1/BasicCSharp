// See https://aka.ms/new-console-template for more information
using LeetCode._1._Hashmap;
using LeetCode._2._Stack;
using LeetCode._6._Backtrack;
using LeetCode.LinkedList;
using LeetCode.LINQ;


// HashMap
ValidAnagram v = new ValidAnagram();
Console.WriteLine(v.IsAnagram("anagram", "nagaram"));
Console.WriteLine(v.IsAnagram("rat", "car"));

Group_Anagram v2 = new Group_Anagram();
string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
IList<IList<string>> result = v2.GroupAnagrams(strs);
var resultString = result.Select(group => string.Join(" ", group));

foreach (var group in resultString)
    Console.WriteLine("[ {0} ]", group);

/*
// Stack
Valid_Parentheses vp = new Valid_Parentheses();
Console.WriteLine(vp.IsValid("()[]{}"));

// Backtrack
Subset sb = new Subset();
int[] nums = { 1, 2, 3 };
IList<IList<int>> subsets = sb.Subsets(nums);

Console.WriteLine("All Subsets:");
foreach(var subset in subsets)
{
    Console.Write("[");
    Console.Write(string.Join(" ", subset));
    Console.Write("]");
}
*/

//MainLL m = new MainLL();

Main_LINQ main_LINQ = new Main_LINQ();

Console.ReadLine();