using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Casting
{
    internal class Casting
    {
        
        public Casting() 
        {
            int serialNo = 150;
            string accountNo = "";
            float anyNo = 3.9f;

            accountNo = serialNo.ToString();

            // anyNo = serialNo;

            serialNo = Convert.ToInt32(anyNo);
            serialNo = (int)anyNo;

            Console.WriteLine(serialNo);

        }

    }
}
