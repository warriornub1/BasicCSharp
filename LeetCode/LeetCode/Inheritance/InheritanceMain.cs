using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Inheritance
{
    internal class InheritanceMain
    {
        public InheritanceMain() 
        {
            Student me = new Student();
            me.FirstName = "Jingle";
            me.Verified = true;
            me.HelloToConsole();
            me.HelloToConsole1();

        }
    }
}
