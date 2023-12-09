using System.Collections.Generic;

namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            return InorderTraversalWithIteration(root);
        }


        // Time Complexity: O(n)
        // Space Complexity: O(n)
        // Auxiliary Space Complexity: O(n)
        private IList<int> InorderTraversalWithRecursion(TreeNode root)
        {
            var values = new List<int>();
            
            InorderTraversalRecursionStep(root, values);

            return values;
        }

        private void InorderTraversalRecursionStep(TreeNode root, IList<int> values)
        {
            if (root is null) return;
            
            InorderTraversalRecursionStep(root.left, values);
            values.Add(root.val);
            InorderTraversalRecursionStep(root.right, values);
        }

        private IList<int> InorderTraversalWithIteration(TreeNode root)
        {
            var values = new List<int>();
            
            if (root is null) return values;
            
            var nodeStack = new Stack<TreeNode>();
            var ignoreLeft = false;

            nodeStack.Push(root);

            while (nodeStack.Count > 0)
            {
                var currentNode = nodeStack.Peek();

                if (currentNode.left is null || ignoreLeft)
                {
                    values.Add(currentNode.val);
                    nodeStack.Pop();

                    ignoreLeft = currentNode.right is null;
                    
                    if (currentNode.right is not null)
                    {
                        nodeStack.Push(currentNode.right);
                    }
                    
                    continue;
                }

                nodeStack.Push(currentNode.left);
            }

            return values;
        }
        
        
        public class TreeNode 
        { 
            public int val; 
            public TreeNode left; 
            public TreeNode right; 
            
            
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) 
            {
                this.val = val; 
                this.left = left; 
                this.right = right;
            }
        }
    }
}