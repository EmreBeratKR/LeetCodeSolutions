using System;
using System.Collections.Generic;

namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution 
    {
        public int LengthOfLongestSubstring(string s) 
        {
            if (s.Length <= 1) return s.Length;

            var left = 0;
            var right = 0;
            var longest = 1;
            var chars = new Dictionary<char, int>()
            {
                {s[left], 1}
            };

            while (true)
            {
                right += 1;

                if (right >= s.Length) break;

                while (chars.ContainsKey(s[right]) && chars[s[right]] > 0)
                {
                    chars[s[left]] -= 1;
                    left += 1;
                }

                if (chars.ContainsKey(s[right]))
                {
                    chars[s[right]] += 1;
                }

                else
                {
                    chars[s[right]] = 1;
                }

                longest = Math.Max(longest, right - left + 1);
            }

            return longest;
        }
    }
}