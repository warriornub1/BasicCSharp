using LeetCode.Linklist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
    public class MainLL
    {
        public MainLL()
        {
            //Test Sum Of Number
            // 2 -> 4 -> 3
            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);

            // 5 -> 6 -> 4
            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);

            Sum_Of_Number s = new Sum_Of_Number();
            ListNode result = s.AddTwoNumbers(l1, l2);

            while (result != null)
            {
                Console.Write(result.val);
                result = result.next;
            }
        }
    }
}
