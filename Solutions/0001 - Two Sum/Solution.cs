using System.Collections.Generic;

namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            return TwoSumWithDictionary(nums, target);
        }


        // Time Complexity: O(n^2)
        // Space Complexity: O(n)
        // Auxiliary Space Complexity: O(1)
        private int[] TwoSumWithBruteForce(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length - 1; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target) return new []{i, j};
                }
            }
            
            return new int[]{};
        }
        
        // Time Complexity: O(n)
        // Space Complexity: O(n)
        // Auxiliary Space Complexity: O(n)
        private int[] TwoSumWithDictionary(int[] nums, int target)
        {
            var pairs = new Dictionary<int, int>();
        
            for (var i = 0; i < nums.Length; i++)
            {
                var number = nums[i];
                var remainder = target - number;

                if (pairs.TryGetValue(remainder, out var pair))
                {
                    return new []{pair, i};
                }

                pairs[number] = i;
            }

            return new int[]{};
        }
    }
}