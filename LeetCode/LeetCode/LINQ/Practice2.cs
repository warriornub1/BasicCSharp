using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LINQ
{
    internal class Practice2
    {
        public Practice2()
        {
            Console.WriteLine("Practice2");
            List<Database> db = new List<Database>
            {
                new Database{id = 2, family_id = 3, name = "1st" },
                new Database{id = 2, family_id = 4, name = "2nd"},
                new Database{id = 2, family_id = 5, name = "3rd"}

            };


            List<Query> query = new List<Query>
            {
                new Query{Query_id = 2, Query_family_id = 10},
                new Query{Query_id = 2, Query_family_id = 10}
            };

            var result = from d in db
                         where query.Any(q => q.Query_id == d.id && q.Query_family_id == d.family_id)
                         select new { d.id, d.family_id, d.name };


            foreach (var res in result)
            {
                Console.WriteLine(res);
            }


        }

        
    }

    public class Database
    {
        public int id { get; set; }
        public int family_id { get; set; }
        public string name { get; set; }
    }

    public class Query
    {
        public int Query_id { get; set; }
        public int Query_family_id { get; set; }
    }
}
