using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static LeetCode.LINQ.SelectMany;

namespace LeetCode.LINQ
{
    internal class SelectMany
    {
        public class Database()
        {
            public int family_id { get; set; }
            public int attribute_id { get; set; }
        }
       
        public class CreateFamilyAttributeModel
        {
            public int family_id { get; set; }
            public List<AttributeTest> attribute { get; set; }

        }

        public class AttributeTest()
        {
            public int id { get; set; }

            [StringLength(1)]
            public string complete_flag { get; set; }
        }

        public SelectMany()
        {
            var database = new List<Database>
            {
                new Database { family_id = 1, attribute_id = 1 },
                new Database { family_id = 2, attribute_id = 2 },
            };
            var requests = new List<CreateFamilyAttributeModel>
            {
                new CreateFamilyAttributeModel
                {
                    family_id = 1,
                    attribute = new List<AttributeTest>
                    {
                        new AttributeTest { id = 1, complete_flag = "Y" },
                        new AttributeTest { id = 3, complete_flag = "N" },
                    }
                },

                new CreateFamilyAttributeModel
                {
                    family_id = 1,
                    attribute = new List<AttributeTest>
                    {
                        new AttributeTest { id = 2, complete_flag = "Y" },
                        new AttributeTest { id = 3, complete_flag = "N" },
                    }
                },

            };
            
            // Flatten Object
            var flatten_request = requests.SelectMany(fam => fam.attribute, 
                (fam, attr) => new { fam.family_id, attr_id = attr.id, attr.complete_flag });
            foreach( var data in flatten_request )
            {
                Console.WriteLine($"Family ID: {data.family_id}, Attribute ID: {data.attr_id}, Complete Flag: {data.complete_flag}");

            }


            // Check for duplicated family_id & attr_id in request
            var duplicate = flatten_request.GroupBy(attr => new { attr.family_id, attr.attr_id })
                                            .Where(x => x.Count() > 1)
                                            .Select(group => $"[ {group.Key.family_id} -  {group.Key.attr_id} ]");

            foreach( var dup in duplicate )
            {
                Console.WriteLine($"Duplicate : {dup}");
            }

            // Check request against database for duplicated records
            var duplicated_db_records = database.Where(db => flatten_request
                                                            .Select(rq => rq.family_id).Contains(db.family_id)
                                                            && flatten_request
                                                            .Select(rq => rq.attr_id).Contains(db.attribute_id))
                                                        .Select(x => $"[ {x.family_id} - {x.attribute_id} ]")
                                                        .ToList();

            foreach (var dup in duplicated_db_records)
            {
                Console.WriteLine($"Duplicate : {dup}");
            }


        }
    }
}
