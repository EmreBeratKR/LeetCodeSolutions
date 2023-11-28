using System;
using System.Collections.Generic;

namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution 
    {
        public bool ContainsDuplicate(int[] nums)
        {
            return ContainsDuplicateWithHashSet(nums);
        }


        // Time Complexity: O(n^2)
        // Space Complexity: O(n)
        // Auxiliary Space Complexity: O(1)
        private bool ContainsDuplicateWithBruteForce(int[] nums)
        {
            for (var i = 0; i < nums.Length - 1; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j]) return true;
                }
            }

            return false;
        }
        
        // Time Complexity: O(nlogn)
        // Space Complexity: O(n)
        // Auxiliary Space Complexity: O(1)
        private bool ContainsDuplicateWithSorting(int[] nums)
        {
            Array.Sort(nums);

            for (var i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1]) return true;
            }

            return false;
        }

        // Time Complexity: O(n)
        // Space Complexity: O(n)
        // Auxiliary Space Complexity: O(n)
        private bool ContainsDuplicateWithHashSet(int[] nums)
        {
            var hashSet = new HashSet<int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (hashSet.Contains(nums[i])) return true;

                hashSet.Add(nums[i]);
            }

            return false;
        }
    }
}