using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AlgorithmCode.Tree;
using System.Collections.Generic;

namespace AlgorithmCodeTest.Tree
{
    [TestClass]
    public class TreeNodeTest
    {
        [TestMethod]
        public void FirstTraversalTest()
        {
            TreeNode<string> root = new TreeNode<string>("A", new TreeNode<string>("B", new TreeNode<string>("C"), new TreeNode<string>("D")), new TreeNode<string>("E", null, new TreeNode<string>("F")));
            string[] output = { "A", "B", "C", "D", "E", "F" };

            IList<string> res = TreeNode<string>.FirstTraversal(root);

            bool isOK = true;
            for (int i = 0; i < output.Length; i++)
            {
                if (output[i] != res[i])
                {
                    isOK = false;
                    break;
                }
            }

            Assert.IsTrue(isOK);
        }

        [TestMethod]
        public void MidTraversalTest()
        {
            TreeNode<string> root = new TreeNode<string>("A", new TreeNode<string>("B", new TreeNode<string>("C"), new TreeNode<string>("D")), new TreeNode<string>("E", null, new TreeNode<string>("F")));
            string[] output = { "C", "B", "D", "A", "E", "F" };

            IList<string> res = TreeNode<string>.MidTraversal(root);

            bool isOK = true;
            for (int i = 0; i < output.Length; i++)
            {
                if (output[i] != res[i])
                {
                    isOK = false;
                    break;
                }
            }

            Assert.IsTrue(isOK);
        }

        [TestMethod]
        public void AfterTraversalTest()
        {
            TreeNode<string> root = new TreeNode<string>("A", new TreeNode<string>("B", new TreeNode<string>("C"), new TreeNode<string>("D")), new TreeNode<string>("E", null, new TreeNode<string>("F")));

            string[] output = { "C", "D", "B", "F", "E", "A" };

            IList<string> res = TreeNode<string>.AfterTraversal(root);

            bool isOK = true;
            for (int i = 0; i < output.Length; i++)
            {
                if (output[i] != res[i])
                {
                    isOK = false;
                    break;
                }
            }

            Assert.IsTrue(isOK);
        }

        [TestMethod]
        public void LevelOrderTest() {
            TreeNode<string> root = new TreeNode<string>("A", new TreeNode<string>("B", new TreeNode<string>("D"), new TreeNode<string>("E")), new TreeNode<string>("C", null, new TreeNode<string>("F")));

            string[] output = { "A", "B", "C", "D", "E", "F" };

            IList<string> res = TreeNode<string>.LevelOrder(root);

            bool isOK = true;
            for (int i = 0; i < output.Length; i++)
            {
                if (output[i] != res[i])
                {
                    isOK = false;
                    break;
                }
            }

            Assert.IsTrue(isOK);
        }
    }
}
