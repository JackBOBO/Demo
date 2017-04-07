import org.junit.Test;

import static org.junit.Assert.*;

/**
 * Created by chenlong on 2017/4/3.
 */
public class ListNodeTest {
    @Test
    public void reverseKGroup() throws Exception {
        ListNode input = new ListNode(1,new ListNode(2,new ListNode(3,new ListNode(4,new ListNode(5)))));
        ListNode output = new ListNode(2,new ListNode(1,new ListNode(4,new ListNode(3,new ListNode(5)))));

        ListNode res = ListNode.reverseKGroup(input,2);

        boolean isOK = true;
        while (output != null)
        {
            if (output.val != res.val)
            {
                isOK = false;
                break;
            }

            output = output.next;
            res = res.next;
        }

        assertEquals("reverseKGroup",true,isOK);
    }

    @Test
    public void addTowNumber() throws Exception {
        ListNode input1 = new ListNode(2,new ListNode(4,new ListNode(6)));
        ListNode input2 = new ListNode(5,new ListNode(6,new ListNode(4)));
        ListNode output = new ListNode(7,new ListNode(0,new ListNode(1,new ListNode(1))));

        ListNode res = ListNode.addTowNumber(input1,input2);
        boolean isOK = true;

        while (res != null && output != null)
        {
            if (res.val != output.val)
            {
                isOK = false;
                break;
            }

            res = res.next;
            output = output.next;
        }

        assertEquals("",true,isOK);
    }

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