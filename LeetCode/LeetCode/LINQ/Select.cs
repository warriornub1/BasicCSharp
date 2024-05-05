using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LINQ
{
    public class Select
    {
        public Select()
        {
            List<Winner> list = new()
            {
                new Winner() { Country = "Argentina", Years = new[] { 1978, 1986, 2022 } },
                new Winner() { Country = "England  ", Years = new[] { 1966 } },
                new Winner() { Country = "Germany  ", Years = new[] { 1954, 1974, 1990, 2014 } },
            };

            List<String> countries = list.Select(x => x.Country).ToList();
            List<int[]> listOfArrays = list.Select(w => w.Years).ToList();

            List<int> aggregatedList = list.SelectMany(w => w.Years).ToList();
            foreach(var entry in aggregatedList)
            {
                Console.WriteLine(entry);
            }

            var customList = list.SelectMany(w => w.Years, (w, y) => new {Country = w.Country, Year = y} )
                .OrderBy(e => e.Year)
                .ToList();

            string[] cols = new[] { "A", "B", "C"};
            string[] rows = new[] { "1", "2", "3" };

            var crossApply = cols.SelectMany(col => rows, (col, row) => $"{col}{row}").ToList();
            Console.WriteLine("\ncrossApply :-");
            foreach(var entry in crossApply)
                Console.WriteLine(entry);


        }
    }

    public class Winner
    {
        public required string Country { get; set; }
        public required int[] Years { get; set; }

    }
}
