using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmCode.Tree
{
    public class TreeNode<T>
    {
        public T Val { get; set; }

        public TreeNode<T> Left { get; set; }

        public TreeNode<T> Right { get; set; }

        public TreeNode()
        {
        }

        public TreeNode(T val) : this(val, null, null)
        {
        }

        public TreeNode(T val, TreeNode<T> left, TreeNode<T> right)
        {
            this.Val = val;
            this.Left = left;
            this.Right = right;
        }

        public static IList<T> FirstTraversal(TreeNode<T> root)
        {
            IList<T> res = new List<T>();

            FirstTraversal(root, res);

            return res;
        }

        private static void FirstTraversal(TreeNode<T> root, IList<T> res)
        {
            if (root != null)
            {
                res.Add(root.Val);
                FirstTraversal(root.Left, res);
                FirstTraversal(root.Right, res);
            }
        }

        public static IList<T> MidTraversal(TreeNode<T> root)
        {
            IList<T> res = new List<T>();

            MidTraversal(root, res);

            return res;
        }


        private static void MidTraversal(TreeNode<T> root, IList<T> res)
        {
            if (root != null)
            {
                MidTraversal(root.Left, res);
                res.Add(root.Val);
                MidTraversal(root.Right, res);
            }
        }

        public static IList<T> AfterTraversal(TreeNode<T> root)
        {
            IList<T> res = new List<T>();

            AfterTraversal(root, res);

            return res;
        }

        private static void AfterTraversal(TreeNode<T> root, IList<T> res)
        {
            if (root != null)
            {
                AfterTraversal(root.Left, res);
                AfterTraversal(root.Right, res);
                res.Add(root.Val);
            }
        }

        public static IList<T> LevelOrder(TreeNode<T> root)
        {
            Queue queue = new Queue();
            IList<T> res = new List<T>();

            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                TreeNode<T> treeNode = (TreeNode<T>)queue.Dequeue();
                res.Add(treeNode.Val);
                if (treeNode.Left != null)
                    queue.Enqueue(treeNode.Left);

                if (treeNode.Right != null)
                    queue.Enqueue(treeNode.Right);
            }

            return res;
        }
    }
}
