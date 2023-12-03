namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution 
    {
        public int MissingNumber(int[] nums)
        {
            return MissingNumberWithGaussSum(nums);
        }
        
        
        // Time Complexity: O(n)
        // Space Complexity: O(n)
        // Auxiliary Space Complexity: O(1)
        private int MissingNumberWithGaussSum(int[] nums)
        {
            var gaussSum = (nums.Length + 1) * nums.Length / 2;

            for (var i = 0; i < nums.Length; i++)
            {
                gaussSum -= nums[i];
            }

            return gaussSum;
        }
    }
}