[leet]: https://leetcode.com/problems/majority-element/

# [169 - Majority Element][leet]

## ```Easy```

- Given an array `nums` of size `n`, return _the majority element_.
- The majority element is the element that appears more than `⌊n / 2⌋` times. 
- You may assume that the majority element always exists in the array.

### Example 1:

```
Input: nums = [3,2,3]
Output: 3
```

### Example 2:

```
Input: nums = [2,2,1,1,1,2,2]
Output: 2
```

### Constraints

- `n == nums.length`
- `1 <= n <= 5 * 10^4`
- `-10^9 <= nums[i] <= 10^9`


**Follow-up:** Could you solve the problem in linear time and in `O(1)` space?


## My Solution

```cs
public int MajorityElement(int[] nums)
{
    var candidate = int.MinValue;
    var count = 0;

    for (var i = 0; i < nums.Length; i++)
    {
        if (count == 0)
        {
            candidate = nums[i];
            count = 1;
            continue;
        }

        count += candidate == nums[i] ? 1 : -1;
    }

    return candidate;
}
```

### Performance

- Time Complexity: ```O(n)```
- Space Complexity: ```O(n)```
- Auxiliary Space Complexity: ```O(1)```
