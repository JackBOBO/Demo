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

        /// <summary>
        /// 反转一个链表
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode Reverse(ListNode head)
        {
            if (head == null || head.Next == null) return head;

            ListNode temp = Reverse(head.Next);
            head.Next.Next = head;
            head.Next = null;

            return temp;
        }

        /// <summary>
        /// 删除链表倒数第N个节点方法1
        /// </summary>
        /// <param name="head"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static int RemoveReciprocalByIndex(ListNode head, int index)
        {
            if (index <= 0 || head == null || head.Next == null)
                return index;

            int reciprocalIndex = RemoveReciprocalByIndex(head.Next, index) - 1;

            if (reciprocalIndex == 0)
                head.Next = head.Next.Next;

            return reciprocalIndex;
        }

        /// <summary>
        /// 删除链表倒数第N个节点方法2
        /// </summary>
        /// <param name="head"></param>
        /// <param name="n"></param>
        /// <returns></returns>
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
