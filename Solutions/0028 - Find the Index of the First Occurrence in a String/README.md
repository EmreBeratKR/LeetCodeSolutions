[leet]: https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/description/

# [28 - Find the Index of the First Occurrence in a String][leet]

## ```Easy```

- Given two strings `needle` and `haystack`, return the index of the first occurrence of `needle` in `haystack`, or `-1` if `needle` is not part of `haystack`.

### Example 1:

```
Input: haystack = "sadbutsad", needle = "sad"
Output: 0
Explanation: "sad" occurs at index 0 and 6.
The first occurrence is at index 0, so we return 0.
```

### Example 2:

```
Input: haystack = "leetcode", needle = "leeto"
Output: -1
Explanation: "leeto" did not occur in "leetcode", so we return -1.
```

### Constraints
- `1 <= haystack.length, needle.length <= 10^4`
- `haystack` and `needle` consist of only lowercase English characters.

## My Solution(s)

### 1) Sliding Window

#### Complexity:

- Time Complexity: ```O(n*m)```
- Space Complexity: ```O(n)```
- Auxiliary Space Complexity: ```O(1)```

#### Explanation:

- Create a window with length of needle's lenght.
- Slide the window right if current is not valid.
- Return -1 if we reach end of the haystack.
- Return current window's start index if is valid.

```cs
public int StrStr(string haystack, string needle)
{
    if (haystack.Length < needle.Length) return -1;
    
    for (var i = 0; i < haystack.Length; i++)
    {
        var isValid = true;

        if (haystack.Length - i < needle.Length) return -1;

        for (var j = 0; j < needle.Length; j++)
        {
            if (haystack[i + j] == needle[j]) continue;
            
            isValid = false;
            break;
        }
        
        if (!isValid) continue;

        return i;
    }

    return -1;
}
```
