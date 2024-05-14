using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LINQ
{
    internal class State
    {
        public int stateId { get; set; }
        public string stateName { get; set; }

        public static IEnumerable<State> GetAll()
        {
            List<State> list = new List<State>()
            {
                new State { stateId = 33, stateName = "New York" },
                new State { stateId = 100, stateName = "Hawaii" },
                new State { stateId = 5, stateName = "California" },
                new State { stateId = 14, stateName = "Illinois" },
                new State { stateId = 44, stateName = "Texas" },
                new State { stateId = 3, stateName = "Arizona" },

            };
            return list;
        }
    }
}
