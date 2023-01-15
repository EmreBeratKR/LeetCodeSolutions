namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution
    {
        public int RemoveElement(int[] nums, int val) 
        {
            if (nums.Length <= 0) return 0;

            var left = 0;
            var right = 0;

            while (true)
            {
                if (right >= nums.Length) break;

                if (nums[right] != val)
                {
                    nums[left] = nums[right];
                    left += 1;
                }

                right += 1;
            }

            return left;
        }
    }
}