[leet]: https://leetcode.com/problems/longest-substring-without-repeating-characters/
[link-substring]: https://en.wikipedia.org/wiki/Substring

# [3 - Longest Substring Without Repeating Characters][leet]

## `Medium`

- Given a string `s`, find the length of the **longest** [**substring**][link-substring] without repeating characters.

### Example 1:

```
Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.
```

### Example 2:

```
Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
```

### Example 3:
```
Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
```

### Constraints
- `0 <= s.length <= 5 * 10^4`
- `s` consists of English letters, digits, symbols and spaces.

<br>

## My Solution

```cs
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
```

### Performance

- Time Complexity: ```O(n)```
- Space Complexity: ```O(n)```
- Auxiliary Space Complexity: ```O(n)```
