using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LINQ
{
    public class Join
    {
        public Join() 
        {
            Console.WriteLine();
            Console.WriteLine("Join");
            Console.WriteLine("------------------");
            IEnumerable<State> allState = State.GetAll();
            IEnumerable<City> allCity = City.GetAll();

            // Query syntax
            var StateandCIty = from s in allState // Outer Sequence
                               join c in allCity // Inner Sequence
                               on s.stateId equals c.StateId
                               select new { s.stateName, c.CityId, c.CityName };


            foreach(var sc in StateandCIty)
            {
                Console.WriteLine("{0}\t{1}\t{2}", sc.stateName, sc.CityId, sc.CityName);
            }

            // Method Syntax
            var StateandCty = allState.Join(allCity, 
                s => s.stateId, 
                c => c.StateId, 
                (s, c) => new { s.stateName, c.CityId });

        }

    }
}
