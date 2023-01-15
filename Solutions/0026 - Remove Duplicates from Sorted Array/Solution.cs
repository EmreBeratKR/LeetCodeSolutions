namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution
    {
        public int RemoveDuplicates(int[] nums) 
        {
            if (nums.Length <= 1) return nums.Length;

            var unique = nums[0];
            var left = 1;
            var right = 1;

            while (true)
            {
                if (right >= nums.Length) break;

                if (nums[right] != unique)
                {
                    unique = nums[right];
                    nums[left] = unique;
                    left += 1;
                }

                right += 1;
            }

            return left;
        }
    }
}