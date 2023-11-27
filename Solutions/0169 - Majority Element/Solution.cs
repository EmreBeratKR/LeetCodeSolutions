namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution 
    {
        public int MajorityElement(int[] nums)
        {
            var candidate = int.MinValue;
            var count = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    candidate = nums[i];
                    count = 1;
                    continue;
                }

                count += candidate == nums[i] ? 1 : -1;
            }

            return candidate;
        }
    }
}