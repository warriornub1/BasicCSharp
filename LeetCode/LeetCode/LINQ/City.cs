using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LINQ
{
    internal class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int StateId { get; set; }

        public static IEnumerable<City> GetAll()
        {
            List<City> lstCity = new List<City>()
        {
            new City { CityId = 1, CityName = "New York", StateId = 33 },
            new City { CityId = 2, CityName = "Los Angeles", StateId = 5 },
            new City { CityId = 3, CityName = "Chicago", StateId = 14 },
            new City { CityId = 4, CityName = "Houston", StateId = 44 },
            new City { CityId = 5, CityName = "Phoenix", StateId = 3 }
        };

            return lstCity;
        }
    }
}
