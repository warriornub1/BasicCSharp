using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static LeetCode.Practice.SelectMany;

namespace LeetCode.Practice
{
    public class OrderBy
    {
        public OrderBy()
        {
            var Family = new List<Family>
            {
                new Family { id = 1, identifier = "Trump", name = "Trump" }, // @@@@@@@@ // ########
                new Family { id = 2, identifier = "Biden", name = "Biden" }, 
            };

            var FamilyAttribute = new List<FamilyAttribute>
            {
                new FamilyAttribute { id = 1, family_id= 1, attribute_id = 2, complete_flag = "1" }, // @@@@@@@@@@@
                new FamilyAttribute { id = 2, family_id= 1, attribute_id = 3, complete_flag = "0" }, // ########
            };


            var Attributes = new List<Attributes>
            {
                new Attributes { id = 1, attribute_group_id= 2, identifier = "BD1", name = "BD1" }, 
                new Attributes { id = 2, attribute_group_id= 2, identifier = "BD2", name = "BD2" }, // @@@@@@@@@@
                new Attributes { id = 3, attribute_group_id= 3, identifier = "BD3", name = "BD3" }  // ########
            };

            var AttributeGroups = new List<AttributeGroups>
            {
                new AttributeGroups { id = 1, identifier= "Bore Diameter", name = "Bore Diameter", display_seq = 1 },
                new AttributeGroups { id = 2, identifier= "Outer Diameter", name = "Outer Diameter", display_seq = 3 }, // @@@@@@@@@@@@
                new AttributeGroups { id = 3, identifier= "Put Diameter", name = "Put Diameter", display_seq = 2 },  // ########
            };


            int id = 1;

            var combine_groups = from fa in FamilyAttribute
                                join attr in Attributes on fa.attribute_id equals attr.id
                                where fa.family_id == id
                                group new { fa, attr } by new { fa.family_id, attr.attribute_group_id } into grouped
                                select new
                                {
                                    FamilyId = grouped.Key.family_id,
                                    AttributeGroupId = grouped.Key.attribute_group_id,
                                };


            var combined_identifier_name = from fa in FamilyAttribute
                                           join attr in Attributes on fa.attribute_id equals attr.id
                                           where fa.family_id == id
                                           select new
                                           {
                                               FamilyId = fa.family_id,
                                               complete_flag = fa.complete_flag,
                                               name = attr.name,
                                               identifier = attr.identifier,
                                               AttributeGroupId = attr.attribute_group_id,
                                           };

            var result = Family.Where(f => f.id == id)
                    .Select(f => new DTO
                    {
                        id = f.id,
                        identifier = f.identifier,
                        name = f.name,
                        attributes_list = (from ca in combine_groups
                                           join attrGroup in AttributeGroups on ca.AttributeGroupId equals attrGroup.id
                                           orderby attrGroup.display_seq
                                           select new attributes_group
                                           {
                                               attribute_group_id = attrGroup.id,
                                               attribute_group_identifier = attrGroup.identifier,
                                               attribute_group_name = attrGroup.name,
                                               attribute = (from cin in combined_identifier_name
                                                            where cin.AttributeGroupId == ca.AttributeGroupId
                                                            select new attribute
                                                            {
                                                                attribute_id = cin.AttributeGroupId,
                                                                attribute_identifier = cin.identifier,
                                                                attribute_name = cin.name,
                                                                complete_flag = cin.complete_flag,
                                                            }).ToList()
                                           }).ToList()
                    }).ToList();

            /*
            var result = Family.Where(f => f.id == id)
                    .Select(f => new DTO
                    {
                        id = f.id,
                        identifier = f.identifier,
                        name = f.name,
                        attributes_list = (from fa in FamilyAttribute
                                           join attr in Attributes on fa.attribute_id equals attr.id
                                           join attrGroup in AttributeGroups on attr.attribute_group_id equals attrGroup.id
                                           orderby attrGroup.display_seq
                                           select new attributes_group
                                           {
                                               attribute_id = attrGroup.id,
                                               attribute_identifier = attrGroup.identifier,
                                               attribute_name = attrGroup.name,
                                               attribute = (from faa in FamilyAttribute
                                                           select new attribute 
                                                           {
                                                                attribute_id = attr.id,
                                                                attribute_identifier = attr.identifier,
                                                                attribute_name = attr.name,
                                                                complete_flag = faa.complete_flag
                                                           }).ToList()
                                           }).ToList()
                    }).ToList();
            */

        }

    }
    public class Family()
    {
        public int id { get; set; }
        public string identifier { get; set; }
        public string name { get; set; }
    }

    public class FamilyAttribute()
    {
        public int id { get; set; }
        public int family_id { get; set; }
        public int attribute_id { get; set; }
        public string complete_flag { get; set; }
    }

    public class AttributeGroups()
    {
        public int id { get; set; }
        public string identifier { get; set; }
        public string name { get; set; }
        public int display_seq { get; set; }
    }

    public class Attributes()
    {
        public int id { get; set; }
        public int attribute_group_id { get; set; }
        public string identifier { get; set; }
        public string name { get; set; }
    }
}
