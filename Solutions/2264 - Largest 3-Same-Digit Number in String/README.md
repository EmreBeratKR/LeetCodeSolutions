[leet]: https://leetcode.com/problems/largest-3-same-digit-number-in-string/

# [2264 - Largest 3-Same-Digit Number in String][leet]

## ```Easy```

- You are given a string `num` representing a large integer. An integer is `good` if it meets the following conditions:
  - It is a **substring** of `num` with length `3`.
  - It consists of only one unique digit.
- Return _the **maximum good** integer as a **string** or an empty string `""` if no such integer exists._
- Note:
  - A **substring** is a contiguous sequence of characters within a string.
  - There may be **leading zeroes** in `num` or a good integer.

### Example 1:

```
Input: num = "6777133339"
Output: "777"
Explanation: There are two distinct good integers: "777" and "333".
"777" is the largest, so we return "777".
```

### Example 2:

```
Input: num = "2300019"
Output: "000"
Explanation: "000" is the only good integer.
```

### Example 3:

```
Input: num = "42352338"
Output: ""
Explanation: No substring of length 3 consists of only one unique digit. Therefore, there are no good integers.
```

### Constraints

- `3 <= num.length <= 1000`
- **num** only consists of digits.


## My Solution(s)

### 1) ???

#### Complexity:

- Time Complexity: ```O(n)```
- Space Complexity: ```O(n)```
- Auxiliary Space Complexity: ```O(1)```

#### Explanation:

- Iterate over all digits.
- If current digit is not equal to current candidate it is now our new candidate.
- And length is reset to 1 as our candidate is changed.
- Else if current digit is equal to current candidate increment length by 1.
- And after the incrementation if `length >= 3` then its a **Good Integer**.
- If this **Good Integer** is larger than our current **best Good Intege**r update it.
- Else just ignore it.
- If we found any **Good Integer**, we return it by checking if `best >= 0`.

```cs
public string LargestGoodInteger(string num)
{
    var candidate = int.MinValue;
    var best = int.MinValue;
    var length = 0;

    for (var i = 0; i < num.Length; i++)
    {
        var digit = CharDigitToInt(num[i]);
    
        if (digit != candidate)
        {
            candidate = digit;
            length = 1;
            continue;
        }

        length += 1;
    
        if (length < 3) continue;

        best = Math.Max(best, candidate);
    }

    return best >= 0 ? $"{best}{best}{best}" : "";
}


private int CharDigitToInt(char digit)
{
    return digit switch
    {
        '0' => 0,
        '1' => 1,
        '2' => 2,
        '3' => 3,
        '4' => 4,
        '5' => 5,
        '6' => 6,
        '7' => 7,
        '8' => 8,
        '9' => 9,
        _ => default
    };
}
```
