using System.Collections.Generic;

namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution
    {
        public IList<int> InorderTraversal(TreeNode root) 
        {
            return default;    
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