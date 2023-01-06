using System.Collections.Generic;

namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var pairs = new Dictionary<int, int>();
        
            for (var i = 0; i < nums.Length; i++)
            {
                var number = nums[i];
                var remainder = target - number;

                if (pairs.ContainsKey(remainder))
                {
                    return new int[] {pairs[remainder], i};
                }

                pairs[number] = i;
            }

            return new int[] { };
        }
    }
}