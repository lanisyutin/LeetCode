using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_two_numbers
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        static public void Main()
        {
            ListNode l1 = new ListNode(5);

            ListNode l4 = new ListNode(5);

            var list = AddTwoNumbers(l1, l4);
        }
        static public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode res = new ListNode(0);
            var result = res;
            int inMind = 0;
            if (l1.val + l2.val < 10)
            {
                res.val += l1.val + l2.val;
            }
            else
            {
                res.val += (l1.val + l2.val) % 10;
                inMind = (l1.val + l2.val) / 10;
            }
            l1 = l1.next;
            l2 = l2.next;
            while (l1 != null && l2 != null)
            {
                var newlist = new ListNode(0);
                res.next = newlist;
                if (l1.val + l2.val + inMind < 10)
                {
                    newlist.val += l1.val + l2.val + inMind;
                    inMind = 0;
                }
                else
                {
                    newlist.val += (l1.val + l2.val + inMind) % 10;
                    inMind = (l1.val + l2.val + inMind) / 10;
                }
                res = res.next;
                l1 = l1.next;
                l2 = l2.next;
            }

            while (l1 != null)
            {
                var newlist = new ListNode(0);
                res.next = newlist;
                if (l1.val + inMind < 10)
                {
                    newlist.val += l1.val + inMind;
                    inMind = 0;
                }
                else
                {
                    newlist.val += (l1.val +  inMind) % 10;
                    inMind = (l1.val + inMind) / 10;
                }
                res = res.next;
                l1 = l1.next;

            }
            while (l2 != null)
            {
                var newlist = new ListNode(0);
                res.next = newlist;
                if (l2.val + inMind < 10)
                {
                    newlist.val += l2.val + inMind;
                    inMind = 0;
                }
                else
                {
                    newlist.val += (l2.val + inMind) % 10;
                    inMind = (l2.val + inMind) / 10;
                }
                res = res.next;
                l2 = l2.next;
            }
            if (inMind != 0)
            {
                var newlist = new ListNode(inMind);
                res.next = newlist;
            }
            return result;
        }
    }
}
