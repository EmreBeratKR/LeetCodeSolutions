namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution 
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
        {
            var nodeOne = l1;
            var nodeTwo = l2;

            if (nodeOne.GetLength() < nodeTwo.GetLength())
            {
                (nodeOne, nodeTwo) = (nodeTwo, nodeOne);
            }

            var start = nodeOne;
            var sum = 0;

            while (true)
            {
                sum = sum > 9 ? 1 : 0;
                sum += nodeOne.val;
                sum += nodeTwo == null ? 0 : nodeTwo.val;
                nodeOne.val = sum > 9 ? sum - 10 : sum;

                if (nodeOne.next == null)
                {
                    if (sum > 9)
                    {
                        nodeOne.next = new ListNode(1);
                    }

                    return start;
                }

                nodeOne = nodeOne.next;

                if (nodeTwo == null) continue;

                nodeTwo = nodeTwo.next;
            }
        }
    }

    public static class ListNodeExtensions
    {
        public static int GetLength(this ListNode node)
        {
            var length = 0;
            var currentNode = node;

            while (currentNode != null)
            {
                length += 1;
                currentNode = currentNode.next;
            }

            return length;
        }
    }
    
    //* Definition for singly-linked list.
    public class ListNode 
    {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) 
        {
            this.val = val;
            this.next = next; 
        } 
    }
}