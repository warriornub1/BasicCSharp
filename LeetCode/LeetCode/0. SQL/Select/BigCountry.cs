using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode._0._SQL.Select
{
    internal class BigCountry
    {
        public BigCountry() 
        {
            Console.WriteLine();
            Console.WriteLine("BigCountry");
            Console.WriteLine("-------------------");
            List<World> Countries = World.GetAll();

            var countries1 = Countries.Where(x => x.area >= 3000000 || x.population >= 25000000)
                                      .Select(x => new {  x.name, x.population, x.area });
            
            var countries2 = from c in Countries
                             where c.area >= 3000000 || c.population >= 25000000
                             select new { c.name, c.population, c.area };

            foreach( var c in countries1 )
            {
                Console.WriteLine($"{c.name} {c.population} {c.area}");
            }

            foreach (var c in countries2)
            {
                Console.WriteLine($"{c.name} {c.population} {c.area}");
            }
        }
    }

    public class World
    {
        public string name { get; set; }
        public string continent { get; set; }
        public double area { get; set; }
        public int population { get; set; }
        public double gdp { get; set; }

        public World(string name, string continent, double area, int population, double gdp )
        {
            this.name = name;
            this.continent = continent;
            this.area = area;
            this.population = population;
            this.gdp = gdp;
        }
        public static List<World> GetAll()
        {
            return new List<World>
            {
                new World("Afghanistan", "Asia", 652230, 25500100, 20343000000),
                new World("Albania","Europe", 28748, 2831741, 12960000000),
                new World("Algeria", "Africa", 2381741, 37100000, 188681000000),
                new World("Andorra", "Europe", 468, 78115, 3712000000),
                new World("Angola", "Africa", 1246700, 20609294,100990000000),
               };
        }

    }
}
