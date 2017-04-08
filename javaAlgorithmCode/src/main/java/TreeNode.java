import apple.laf.JRSUIUtils;

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

    public static void treeToDoublyList(TreeNode p,TreeNode prev,TreeNode head){

    }
}
