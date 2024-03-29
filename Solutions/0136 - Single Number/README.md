[leet]: https://leetcode.com/problems/single-number/

# [136 - Single Number][leet]

## ```Easy```

- Given a **non-empty** array of integers `nums`, every element appears _twice_ except for one. Find that single one.
- You must implement a solution with a **linear runtime complexity** and use only **constant extra space**.

### Example 1:

```
Input: nums = [2,2,1]
Output: 1
```

### Example 2:

```
Input: nums = [4,1,2,1,2]
Output: 4
```

### Example 3:

```
Input: nums = [1]
Output: 1
```

### Constraints

- ```1 <= nums.length <= 3 * 10^4```
- ```-3 * 10^4 <= nums[i] <= 3 * 10^4```

<br>

## My Solution

```cs
var xor = 0;

for (var i = 0; i < nums.Length; i++)
{
    xor ^= nums[i];
}

return xor;
```

### Performance

- Time Complexity: ```O(n)```
- Space Complexity: ```O(n)```
- Auxiliary Space Complexity: ```O(1)```
