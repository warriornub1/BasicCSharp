using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Inheritance
{
    internal abstract class User
    {
        public bool Verified { get; set; } = false;
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual void HelloToConsole()
        {
            Console.WriteLine("Hi, my name is " + FullName);
        }

        public abstract void HelloToConsole1();

    }
}
