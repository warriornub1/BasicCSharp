using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Inheritance
{
    internal class Student : User
    {
        public override void HelloToConsole()
        {
                Console.WriteLine("Hi, I'm a student, my name is " + FullName.ToUpper());
        }

        public override void HelloToConsole1()
        {
            Console.WriteLine("Hi@@@, I'm a student, my name is " + FullName.ToUpper());
        }
    }
}
