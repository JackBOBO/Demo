import apple.laf.JRSUIUtils;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by chenlong on 2017/4/8.
 */
public class TreeNode {
    int val;
    TreeNode left;
    TreeNode right;

    TreeNode(int value){
        this.val = value;
        left = null;
        right = null;
    }

    TreeNode(int value,TreeNode left,TreeNode right){
        this.val = value;
        this.left = left;
        this.right = right;
    }

    public static TreeNode treeToDoublyList(TreeNode root){
        TreeNode prev = null;
        TreeNode head = null;
        treeToDoublyList(root,prev,head);
        return head;
    }

    /*
     * 二叉树转换双喜那个链表*/
    private static void treeToDoublyList(TreeNode p,TreeNode prev,TreeNode head){
        if (p == null)
            return;

        treeToDoublyList(p.left,prev,head);

        p.left = prev;
        if (prev != null)
            prev.right = p;
        else
            head = p;

        TreeNode right = p.right;
        head.left = p;
        p.right = head;
        prev = p;

        treeToDoublyList(right,prev,head);
    }

    /*
    * 二叉树转换双喜那个链表*/
    public static TreeNode treeToDoublyList1(TreeNode root, TreeNode lastNode) {

        if (root == null)

            return lastNode;

        TreeNode current = root;

        if (current.left != null)

            lastNode=treeToDoublyList1(current.left, lastNode);

        current.left = lastNode;

        if (lastNode != null)

            lastNode.right = current;

        lastNode = current;

        if (current.right != null)

            lastNode=treeToDoublyList1(current.right, lastNode);

        return lastNode;

    }
    /*
    * 最小公共祖先*/
    public static TreeNode LCA(TreeNode root,TreeNode p,TreeNode q) {
        if (root == null || p == null || q == null)
            return null;

        if (root.val > p.val && root.val > q.val)
        {
            return LCA(root.left,p,q);
        }
        else if(root.val < p.val && root.val < q.val)
        {
            return LCA(root.right,p,q);
        }
        else
        {
            return root;
        }

    }
}
