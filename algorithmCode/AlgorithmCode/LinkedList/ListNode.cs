using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCode.LinkedList
{
    public class ListNode
    {
        public ListNode()
        {
        }

        public ListNode(string data) : this(data, null)
        {
        }

        public ListNode(string data, ListNode next)
        {
            this.Data = data;
            this.Next = next;
        }

        public string Data { get; set; }

        public ListNode Next { get; set; }

        public static ListNode Reverse(ListNode head)
        {
            if (head == null || head.Next == null) return head;

            ListNode temp = Reverse(head.Next);
            head.Next.Next = head;
            head.Next = null;

            return temp;
        }

        public static int RemoveReciprocalByIndex(ListNode head, int index)
        {
            if (index <= 0 || head == null || head.Next == null)
                return index;

            int reciprocalIndex = RemoveReciprocalByIndex(head.Next, index) - 1;

            if (reciprocalIndex == 0)
                head.Next = head.Next.Next;

            return reciprocalIndex;
        }

        public static int RemoveReciprocalByIndex2(ListNode head, int n)
        {
            if ( head.Next == null)
                return 0;

            int rank = RemoveReciprocalByIndex2(head.Next, n) + 1;

            if (rank == n)
            { 
                head.Next = head.Next.Next;
                return int.MinValue;
            }

            return rank;
        }

    }
}
