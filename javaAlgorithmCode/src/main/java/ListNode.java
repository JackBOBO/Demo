/**
 * Created by chenlong on 2017/4/3.
 */
public class ListNode {
    int val;
    ListNode next;

    ListNode(int val)
    {
        this.val = val;
        this.next = null;
    }

    ListNode(int val,ListNode next)
    {
        this.val = val;
        this.next = next;
    }

    public static ListNode mergeTowList(ListNode l1,ListNode l2) {
        ListNode dummy = new ListNode(0);
        ListNode cur = dummy;

        while (l1 != null && l2 != null)
        {
            if (l1.val <= l2.val)
            {
                cur.next = l1;
                l1 = l1.next;
            }else
            {
                cur.next = l2;
                l2 = l2.next;
            }

            cur = cur.next;
        }

        if (l1 != null)
        {
            cur.next = l1;
        }else if (l2 != null)
        {
            cur.next = l2;
        }

        return dummy.next;
    }

    public static int getCircleLength(ListNode head) {
        ListNode slow = head;
        if (slow == null || slow.next == null)
            return 0;

        ListNode fast = head.next.next;
        while (fast != null && fast.next != null)
        {
            if (fast == slow)
                return getLength(slow);

            slow = slow.next;
            fast = fast.next.next;
        }

        return 0;
    }

    private static int getLength(ListNode node){
        int length = 1;
        ListNode curr = node;

        while (curr.next != node)
        {
            length ++;
            curr = curr.next;
        }

        return length;
    }
}
