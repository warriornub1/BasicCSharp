using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LINQ
{
    internal class Left_Join
    {
        public Left_Join() 
        {
            IEnumerable<State> allState = State.GetAll();
            IEnumerable<City> allCity = City.GetAll();

            var AllStates = from s in allState // outer collection
                            join c in allCity // inner collection
                            on s.stateId equals c.StateId
                            into myCities
                            from ct in myCities.DefaultIfEmpty()
                            select new { stateId = s.stateId, stateName = s.stateName, cityID = ct == null? 0 : ct.CityId, CityName = ct == null ? "N/A" : ct.CityName };
            
            foreach (var state in AllStates) 
            {
                Console.WriteLine("{0}\t{1}\t{2]\t{3}", state.stateId, state.stateName, state.cityID, state.CityName);

            }

        }
    }
}
