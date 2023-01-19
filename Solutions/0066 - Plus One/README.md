[leet]: https://leetcode.com/problems/plus-one/

# [66 - Plus One][leet]

## ```Easy```

- You are given a **large integer** represented as an integer array `digits`, where each `digits[i]` is the `ith` digit of the integer. 
- The digits are ordered from most significant to least significant in left-to-right order. 
- The large integer does not contain any leading `0`'s.
- Increment the large integer by one and return the resulting array of digits.

### Example 1:

```
Input: digits = [1,2,3]
Output: [1,2,4]
Explanation: The array represents the integer 123.
Incrementing by one gives 123 + 1 = 124.
Thus, the result should be [1,2,4].
```

### Example 2:

```
Input: digits = [4,3,2,1]
Output: [4,3,2,2]
Explanation: The array represents the integer 4321.
Incrementing by one gives 4321 + 1 = 4322.
Thus, the result should be [4,3,2,2].
```

### Example 3:

```
Input: digits = [9]
Output: [1,0]
Explanation: The array represents the integer 9.
Incrementing by one gives 9 + 1 = 10.
Thus, the result should be [1,0].
```

### Constraints

- `1 <= digits.length <= 100`
- `0 <= digits[i] <= 9`
- `digits` does not contain any leading `0`'s.

<br>

## My Solution

```cs
public int[] PlusOne(int[] digits) 
{
    digits[^1] += 1;
    var carry = digits[^1] > 9;

    digits[^1] -= carry ? 10 : 0;

    for (var i = digits.Length - 2; i >= 0; i--)
    {
        digits[i] += carry ? 1 : 0;

        carry = digits[i] > 9;

        if (!carry) continue;

        digits[i] -= 10;
    }

    if (carry)
    {
        var newDigits = new int[digits.Length + 1];

        newDigits[0] = 1;

        for (var i = 0; i < digits.Length; i++)
        {
            newDigits[i + 1] = digits[i];
        }

        digits = newDigits;
    }

    return digits;
}
```

### Performance

- Time Complexity: ```O(n)```
- Space Complexity: ```O(n)```
- Auxiliary Space Complexity: ```O(n)```
