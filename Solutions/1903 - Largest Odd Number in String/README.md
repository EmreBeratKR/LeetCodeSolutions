[leet]: https://leetcode.com/problems/largest-odd-number-in-string/

# [1903 - Largest Odd Number in String][leet]

## ```Easy```

- You are given a string `num`, representing a large integer. Return _the largest-valued odd integer (as a string) that is a **non-empty substring** of `num`, or an empty string `""` if no odd integer exists._
- A **substring** is a contiguous sequence of characters within a string.

### Example 1:

```
Input: num = "52"
Output: "5"
Explanation: The only non-empty substrings are "5", "2", and "52". "5" is the only odd number.

```

### Example 2:

```
Input: num = "4206"
Output: ""
Explanation: There are no odd numbers in "4206".
```

### Example 3:
```
Input: num = "35427"
Output: "35427"
Explanation: "35427" is already an odd number.
```

### Constraints

- `1 <= num.length <= 10^5`
- `num` only consists of digits and does not contain any leading zeros.


## My Solution(s)

### 1) Ones Place

#### Complexity:

- Time Complexity: ```O(n)```
- Space Complexity: ```O(n)```
- Auxiliary Space Complexity: ```O(1)```

#### Explanation:

- Iterate over all characters from the ending of `num`.
- If current character `num[i]` is an odd digit return the substring as `[0, i + 1]`.
- If we haven't found any odd digit return empty string.

```cs
public string LargestOddNumber(string num)
{
    for (var i = num.Length - 1; i >= 0; i--)
    {
        if (IsOddChar(num[i])) return num.Substring(0, i + 1);
    }

    return "";
}


private bool IsOddChar(char digit)
{
    return digit switch
    {
        '1' => true,
        '3' => true,
        '5' => true,
        '7' => true,
        '9' => true,
        _ => false
    };
}
```
