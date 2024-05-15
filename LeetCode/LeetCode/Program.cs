// See https://aka.ms/new-console-template for more information
using LeetCode._0._SQL;
using LeetCode._0._SQL.BasicJoins;
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


linkedList();

DesignPattern();

// SQL
//Recyclable r = new Recyclable();
//CustomerReferee cr = new CustomerReferee();
//ReplaceEmployeeID re = new ReplaceEmployeeID();

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

void DesignPattern()
{
    /*
    Console.WriteLine();
    Console.WriteLine("Design Pattern");
    Console.WriteLine("-------------------");

    SingleResponsibility s = new SingleResponsibility();
    s.AddEntry("I cried today");
    s.AddEntry("I ate a bug");
    Console.WriteLine(s);

    var p = new Persistence();
    var filename = @"C:\Users\kahyong.chua\source\repos\BasicCSharp\LeetCode\LeetCode\Design Pattern\Logs\journal.txt";
    p.SaveToFile(s, filename, true);
    Process.Start("notepad.exe", filename);
    */

    Open_Closed op = new Open_Closed();
}