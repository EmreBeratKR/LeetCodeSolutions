namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution
    {
        public int RemoveDuplicates(int[] nums) 
        {
            if (nums.Length <= 1) return nums.Length;

            var unique = nums[0];
            var i = 1;

            for (var j = i; j < nums.Length; j++)
            {
                if (nums[j] == unique) continue;

                unique = nums[j];
                nums[i] = unique;

                while (nums[j] == unique)
                {
                    j += 1;

                    if (j >= nums.Length) break;
                }

                j -= 1;
                i += 1;
            }

            return i;
        }
    }
}