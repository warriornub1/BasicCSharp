using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static LeetCode.LINQ.Practice;

namespace LeetCode.LINQ
{
    internal class Practice
    {
        public Practice()
        {
            var testDate = new List<CreateFamilyAttributeModel>
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

            /*
            var duplicates = testDate.SelectMany(model => model.attribute, (model, y) => new { family_id = model.family_id, id = y.id })
                                     .GroupBy(attr => new { attr.family_id, attr.id })
                                     .Where(group => group.Count() > 1)
                                     .Select(group => $"[ {group.Key.family_id} - {group.Key.id} ]");


            var attribute_ids = testDate.SelectMany(model => model.attribute)
                                .Select(group => group.id)
                                .ToList();
            */

            var flatten = testDate.SelectMany(fam => fam.attribute, (fam, att) => new { fam.family_id, attribute_id = att.id, att.complete_flag });
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@"); 
            foreach (var item in flatten)
                Console.WriteLine($"Family ID: {item.family_id}, Attribute ID: {item.attribute_id}, Complete Flag: {item.complete_flag}");
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
    }
}
