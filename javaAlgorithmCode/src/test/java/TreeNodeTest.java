import apple.laf.JRSUIUtils;
import org.junit.Test;

import static org.junit.Assert.*;

/**
 * Created by chenlong on 2017/4/9.
 */
public class TreeNodeTest {
    @Test
    public void treeToDoublyList1() throws Exception {

        TreeNode output = new TreeNode(1,null,new TreeNode(3,null,new TreeNode(4,null,new TreeNode(5,null,new TreeNode(7,null,new TreeNode(9))))));
        TreeNode root = new TreeNode(5,new TreeNode(3,new TreeNode(1),new TreeNode(4)),new TreeNode(7,null,new TreeNode(9)));


        TreeNode last = new TreeNode(0);
        TreeNode res = TreeNode.treeToDoublyList1(root,last);

        last = last.right;
        boolean isOK = true;
        while (output != null)
        {
            if (output.val != last.val) {
                isOK = false;
                break;
            }

            output = output.right;
            last = last.right;
        }

        assertEquals("treeToDoublyList",true,isOK);
    }

    @Test
    public void LCATest(){
        TreeNode res = null;
        TreeNode root = new TreeNode(5,new TreeNode(3,new TreeNode(1),new TreeNode(4)),new TreeNode(7,null,new TreeNode(9)));

        res = TreeNode.LCA(root,new TreeNode(1),new TreeNode(9));
        assertEquals("LCATest",5,res.val);

        res = TreeNode.LCA(root,new TreeNode(1),new TreeNode(4));
        assertEquals("LCATest",3,res.val);
    }

}