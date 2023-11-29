[leet]: https://leetcode.com/problems/two-sum/

# [1 - Two Sum][leet]

## ```Easy```

- Given an array of integers ```nums``` and an integer ```target```, return indices of the two numbers such that they add up to ```target```.

- You may assume that each input would have **exactly one solution**, and you may not use the same element twice.

- You can return the answer in any order.

### Example 1:

```
Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
```

### Example 2:

```
Input: nums = [3,2,4], target = 6
Output: [1,2]
```

### Example 3:
```
Input: nums = [3,3], target = 6
Output: [0,1]
```

### Constraints
- ```2 <= nums.length <= 10^4```
- ```-10^9 <= nums[i] <= 10^9```
- ```-10^9 <= target <= 10^9```
- **Only one valid answer exists.**

**Follow-up:** Can you come up with an algorithm that is less than `O(n^2)` time complexity?

## My Solution(s)

### 1) Brute Force

#### Complexity:

- Time Complexity: ```O(n^2)```
- Space Complexity: ```O(n)```
- Auxiliary Space Complexity: ```O(1)```

#### Explanation:

- Check every cases.
- Return true if any of these cases satisfies our conditions.
- Otherwise return false.

```cs
private int[] TwoSumWithBruteForce(int[] nums, int target)
{
    for (var i = 0; i < nums.Length - 1; i++)
    {
        for (var j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target) return new []{i, j};
        }
    }
    
    return new int[]{};
}
```

### 2) Dictionary

#### Complexity:

- Time Complexity: ```O(n)```
- Space Complexity: ```O(n)```
- Auxiliary Space Complexity: ```O(n)```

#### Explanation:

- Iterate over every element in `nums`.
- Calculate `remainder` by subtracting `nums[i]` from `target`.
- If we have seen `remainder` before, return those two indices together.
- Otherwise we store `remainder` with its index inside the dictionary.
- If we never return inside the loop, we return an empty array.

```cs
private int[] TwoSumWithDictionary(int[] nums, int target)
{
    var pairs = new Dictionary<int, int>();

    for (var i = 0; i < nums.Length; i++)
    {
        var number = nums[i];
        var remainder = target - number;

        if (pairs.TryGetValue(remainder, out var pair))
        {
            return new []{pair, i};
        }

        pairs[number] = i;
    }

    return new int[]{};
}
```