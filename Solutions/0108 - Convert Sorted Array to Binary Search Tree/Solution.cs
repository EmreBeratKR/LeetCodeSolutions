namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution
    {
        public TreeNode SortedArrayToBST(int[] nums) 
        {
            if (nums.Length <= 0) return null;

            return SortedArrayToBSTNode(nums, 0, nums.Length - 1);
        }


        private TreeNode SortedArrayToBSTNode(int[] nums, int left, int right)
        {
            if (left > right) return null;

            var middle = (left + right) / 2;
            var leftNode = SortedArrayToBSTNode(nums, left, middle -1);
            var rightNode = SortedArrayToBSTNode(nums, middle + 1, right);
        
            return new TreeNode(nums[middle], leftNode, rightNode);
        }
        
        
        public class TreeNode 
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            
            
            public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) 
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}