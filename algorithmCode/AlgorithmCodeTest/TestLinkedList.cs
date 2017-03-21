using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmCode.LinkedList;

namespace AlgorithmCodeTest
{
    [TestClass]
    public class TestLinkedList
    {
        [TestMethod]
        public void TestReverse()
        {
            bool result = true;
            ListNode input, correct;

            input = new ListNode("1", new ListNode("2", new ListNode("3", new ListNode("4", null))));
            correct = new ListNode("4", new ListNode("3", new ListNode("2", new ListNode("1", null))));

            ListNode output = ListNode.Reverse(input);
            for (int i = 0; ; i++)
            {
                if (!output.Data.Equals(output.Data))
                {
                    result = false;
                    break;
                }

                if (output.Next == null && correct.Next == null)
                {
                    break;
                }
                else
                {
                    output = output.Next;
                    correct = correct.Next;

                }
            }

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestRemoveReciprocalByIndex()
        {
            bool result = true;
            string removeData = "3";
            ListNode input = new ListNode("1", new ListNode("2", new ListNode("3", new ListNode("4", null))));

            ListNode.RemoveReciprocalByIndex(input, 2);

            for (int i = 0; ; i++)
            {
                if (input.Data.Equals(removeData))
                {
                    result = false;
                    break;
                }

                if (input == null || input.Next == null )
                    break;
                else
                    input = input.Next;
            }

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestRemoveReciprocalByIndex2()
        {
            bool result = true;
            string removeData = "3";
            ListNode input = new ListNode("1", new ListNode("2", new ListNode("3", new ListNode("4", null))));

            ListNode.RemoveReciprocalByIndex2(input, 2);

            for (int i = 0; ; i++)
            {
                if (input.Data.Equals(removeData))
                {
                    result = false;
                    break;
                }

                if (input == null || input.Next == null)
                    break;
                else
                    input = input.Next;
            }

            Assert.IsTrue(result);
        }
    }
}
