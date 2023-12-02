using System.Collections.Generic;

namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution 
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            return SummaryRangesWithSlidingWindow(nums);
        }


        // Time Complexity: O(n)
        // Space Complexity: O(n)
        // Auxiliary Space Complexity: O(n)
        private IList<string> SummaryRangesWithSlidingWindow(int[] nums)
        {
            var ranges = new List<string>();

            if (nums.Length <= 0) return ranges;
            
            var a = 0;

            for (var b = 1; ; b++)
            {
                if (b >= nums.Length)
                {
                    ranges.Add(ToRange(nums, a, b - 1));
                    break;
                }
                
                var deltaIndex = b - a;
                var deltaValue = nums[b] - nums[a];
                    
                if (deltaIndex == deltaValue) continue;

                ranges.Add(ToRange(nums, a, b - 1));
                a = b;
            }

            return ranges;
        }
        
        private string ToRange(int[] nums, int a, int b)
        {
            return a == b ? nums[a].ToString() : $"{nums[a]}->{nums[b]}";
        }
    }
}