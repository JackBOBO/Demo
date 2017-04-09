import apple.laf.JRSUIUtils;
import org.junit.Test;

import static org.junit.Assert.*;

/**
 * Created by chenlong on 2017/4/9.
 */
public class TreeNodeTest {
    @Test
    public void treeToDoublyList() throws Exception {
        TreeNode root = new TreeNode(5,new TreeNode(3,new TreeNode(1),new TreeNode(4)),new TreeNode(7,null,new TreeNode(9)));

        TreeNode res = TreeNode.treeToDoublyList(root);

        assertEquals("treeToDoublyList",true,true);
    }

}