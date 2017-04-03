import org.junit.Test;

import static org.junit.Assert.*;

/**
 * Created by chenlong on 2017/4/3.
 */
public class ListNodeTest {
    @Test
    public void getCircleLength() throws Exception {

        ListNode head2 = new ListNode(1);
        head2.next = new ListNode(2,new ListNode(3,new ListNode(4,new ListNode(5,head2))));
        ListNode head1 = new ListNode(3,new ListNode(8,new ListNode(7,head2)));

        int res = ListNode.getCircleLength(head1);
        assertEquals("getCircleLength",5,res);
    }

    @Test
    public void mergeTowList() throws Exception {
        ListNode l1 = new ListNode(5,new ListNode(15));
        ListNode l2 = new ListNode(10,new ListNode(15,new ListNode(20)));

        ListNode output = new ListNode(5,new ListNode(10,new ListNode(15,new ListNode(15,new ListNode(20)))));

        ListNode res = ListNode.mergeTowList(l1,l2);

        boolean isOK = true;
        while (res != null)
        {
            if(res.val != output.val)
            {
                isOK = false;
                break;
            }

            res = res.next;
            output = output.next;

        }

        assertEquals("mergeTowList",true,isOK);
    }

}