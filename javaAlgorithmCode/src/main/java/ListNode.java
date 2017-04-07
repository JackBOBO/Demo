/**
 * Created by chenlong on 2017/4/3.
 */
public class ListNode {
    int val;
    ListNode next;

    ListNode(int val){
        this.val = val;
        this.next = null;
    }

    ListNode(int val,ListNode next){
        this.val = val;
        this.next = next;
    }

    /*
    *合并链表
    */
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

    /*
    * 环的长度
    */
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

    /**
     * 反转链表
     */
    public static ListNode reverse(ListNode head){
        if (head == null || head.next == null)
            return head;

        ListNode temp = ListNode.reverse(head.next);

        head.next = head;
        head.next = null;

        return temp;
    }

    /*
    * 两数相加
    * */
    public static ListNode addTowNumber(ListNode l1,ListNode l2){
        ListNode iter1 = l1,iter2 = l2;
        ListNode list=null ,tail =null;
        int arry = 0;

        while (iter1 != null || iter2 != null || arry != 0)
        {
            int num1 = iter1 == null ? 0 : iter1.val;
            int num2 = iter2 == null ? 0 : iter2.val;

            int sum = num1 + num2 + arry;

            arry = sum / 10;
            sum = sum %10;

            if (list==null)
            {
               list = new ListNode(sum);
               tail = list;
            }
            else
            {
                tail.next = new ListNode(sum);
                tail = tail.next;
            }

            iter1 = iter1 == null ? null : iter1.next;
            iter2 = iter2 == null ? null : iter2.next;
        }

        return list;
    }

    /*
    * 获取链表长度
    * */
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

    /*
    * 分组反转链表
    * */
    public static ListNode reverseKGroup(ListNode head,int k){
        if (head == null || k<= 1)
            return head;

        ListNode dummy = new ListNode(0,head);
        ListNode pre = dummy,cross = head;

        int count =0;
        while (cross != null){
            count++;
            if (count % k == 0)
            {
                pre = reverse(pre,cross.next);
                cross.next = pre;
            }
            else
            {
                cross = cross.next;
            }
        }

        return dummy.next;
    }

    /*
    *
    * */
    private static ListNode reverse(ListNode pre,ListNode next){
        ListNode last = pre.next;
        ListNode cur = last.next;

        while (cur != next)
        {
            last.next = cur.next;
            cur.next = pre.next;

            pre.next = cur;
            cur = last.next;
        }

        return last;
    }
}
