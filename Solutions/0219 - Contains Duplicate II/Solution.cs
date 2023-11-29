using System.Collections.Generic;

namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution 
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            return ContainsNearbyDuplicateDuplicateWithDictionary(nums, k);
        }


        // Time Complexity: O(n^2)
        // Space Complexity: O(n)
        // Auxiliary Space Complexity: O(1)
        private bool ContainsNearbyDuplicateWithBruteForce(int[] nums, int k)
        {
            for (var i = 0; i < nums.Length - 1; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (j - i > k) continue;
                
                    if (nums[i] == nums[j]) return true;
                }
            }

            return false;
        }

        // Time Complexity: O(n)
        // Space Complexity: O(n)
        // Auxiliary Space Complexity: O(n)
        private bool ContainsNearbyDuplicateDuplicateWithDictionary(int[] nums, int k)
        {
            var dictionary = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (!dictionary.TryGetValue(nums[i], out var j))
                {
                    dictionary[nums[i]] = i;
                    continue;
                }

                if (i - j <= k) return true;

                dictionary[nums[i]] = i;
            }

            return false;
        }
    }
}