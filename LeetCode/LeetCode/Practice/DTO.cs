using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Practice
{
    public class DTO
    {
        public int id { get; set; }
        public string identifier { get; set; }
        public string name { get; set; }
        public List<attributes_group> attributes_list { get; set; }
    }

    public class attributes_group
    {
        public int attribute_group_id { get; set; }
        public string attribute_group_identifier { get; set; }
        public string attribute_group_name { get; set; }
        public List<attribute> attribute { get; set; }
    }

    public class attribute
    {
        public int attribute_id { get; set; }
        public string attribute_identifier { get; set; }
        public string attribute_name { get; set; }
        public string complete_flag { get; set; }
    }

}
