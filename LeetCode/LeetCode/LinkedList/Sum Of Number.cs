using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Linklist
{
    public class Sum_Of_Number
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummy_head = new ListNode(0);
            ListNode p = dummy_head;
            int carry = 0;

            while (l1 != null || l2 != null)
            {
                int x = (l1 != null) ? l1.val : 0;
                int y = (l2 != null) ? l2.val : 0;

                int _sum = x + y + carry;
                carry = _sum / 10;

                p.next = new ListNode(_sum % 10);
                p = p.next;

                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
            }

            if (carry > 0)
                p.next = new ListNode(carry);

            ListNode result = dummy_head.next;
            return result;
        }
    }
}
