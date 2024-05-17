// See https://aka.ms/new-console-template for more information
using LeetCode._0._SQL;
using LeetCode._0._SQL.BasicJoins;
using LeetCode._0._SQL.Select;
using LeetCode._1._Hashmap;
using LeetCode._2._Stack;
using LeetCode._6._Backtrack;
using LeetCode.Casting;
using LeetCode.DataStructures.LinkedList;
using LeetCode.DataStructures.Searching;
using LeetCode.DataStructures.Sorting;
using LeetCode.DateTime1;
using LeetCode.Design_Pattern;
using LeetCode.Inheritance;
using LeetCode.LINQ;
using System.Collections.Generic;
using System.Diagnostics;


// Hashing
Hashmap();

// SQL
//SQL();

void Hashmap()
{
    Console.WriteLine("Starting Hashmap");

    Console.WriteLine("\nStarting Contains Duplicate");
    Console.WriteLine("---------------------------");
    ContainsDuplicate c = new ContainsDuplicate(new int[] { 1, 2, 3, 1 });
    ContainsDuplicate c1 = new ContainsDuplicate(new int[] { 1, 2, 3, 4 });
    ContainsDuplicate c2 = new ContainsDuplicate(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 });

    Console.WriteLine("\nStarting Valid Anagram");
    Console.WriteLine("---------------------------");
    Valid_Anagram va = new Valid_Anagram("anagram", "nagaram");
    Valid_Anagram va1 = new Valid_Anagram("rat", "nagaram");
}

void linkedList()
{
    LinkedList L = new LinkedList();
    L.addLast(7);
    L.addLast(4);
    L.addLast(12);

    L.addFirst(1);

    L.addAny(10, 3);
    L.display();
}

void SQL()
{
    //Recyclable r = new Recyclable();
    //CustomerReferee cr = new CustomerReferee();
    BigCountry bg = new BigCountry();
}