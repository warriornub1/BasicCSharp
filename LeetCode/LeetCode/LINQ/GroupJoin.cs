using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LINQ
{

    // https://www.youtube.com/watch?v=IPFqBlXRYFY&list=PLUU6Q8aGTpKXltt2cSKjxO1e-bqZfL2fs&index=22&ab_channel=CodeSemantic

    internal class GroupJoin
    {
        public GroupJoin() 
        {
            Console.WriteLine();
            Console.WriteLine("GoupJoin");
            Console.WriteLine("------------------");
            IEnumerable<State> allState = State.GetAll();
            IEnumerable<City> allCity = City.GetAll();

            // method syntax
            var allStateGrouped = allState.GroupJoin(allCity, 
                                        s => s.stateId, 
                                        c => c.StateId, 
                                        (s, cities) => new { s, cities });

            Console.WriteLine("Method Syntax");
            foreach (var data in allStateGrouped)
            {
                Console.WriteLine(data.s.stateName);
                foreach(var c in data.cities)
                {
                    Console.WriteLine("\t" + c.CityName);
                }

            }

            // query syntax
            var allStateGrouped1 = from s in allState
                                   join c in allCity
                                   on s.stateId equals c.StateId
                                   into mycities
                                   select new { s.stateName, mycities };

            Console.WriteLine("Query Syntax");
            Console.WriteLine("------------------");
            foreach (var data in allStateGrouped1)
            {
                Console.WriteLine(data.stateName);
                foreach (var c in data.mycities)
                {
                    Console.WriteLine("\t" + c.CityName);
                }

            }
        }
    }
}
