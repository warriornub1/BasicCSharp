using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DateTime1
{
    internal class DateTime1
    {
        public DateTime1() 
        {
            DateTime myDate = DateTime.Now;
            string formattedDate = string.Format("Date is {0:yyyy MMM dddd HH mm ss tt}", myDate);
            Console.WriteLine(formattedDate);

            // Practice
            /*
              First format : 30-09-2017 09:09:59
              Second format: Friday of month September year 2017
              Third format : Day Friday
                             Month September
                             Year 2017
            */
            string firstFormat = string.Format("{0:dd-MM-yyyy HH:mm:ss}", myDate);
            string secondFormat = string.Format("{0: dddd} of month {0: MMM} year {0: yyyy}", myDate);
            string thirdFormat = string.Format("{0:'Day:' dddd  \n'Month:' MMM \n'Year:' yyyy}", myDate);

            Console.WriteLine(secondFormat);
            Console.WriteLine(thirdFormat);

        }
    }
}
