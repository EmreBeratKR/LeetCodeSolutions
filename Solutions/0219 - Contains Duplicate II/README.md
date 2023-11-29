[leet]: https://leetcode.com/problems/contains-duplicate-ii/

# [219 - Contains Duplicate II][leet]

## ```Easy```

- Given an integer array `nums` and an integer `k`.
- Return `true` _if there are two **distinct indices**_ `i` _and_ `j` _in the array such that_ `nums[i] == nums[j]` _and_ `abs(i - j) <= k`.

### Example 1:

```
Input: nums = [1,2,3,1], k = 3
Output: true
```

### Example 2:

```
Input: nums = [1,0,1,1], k = 1
Output: true
```

### Example 3:

```
Input: nums = [1,2,3,1,2,3], k = 2
Output: false
```

### Constraints

- `1 <= nums.length <= 10^5`
- `-10^9 <= nums[i] <= 10^9`
- `0 <= k <= 10^5`


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
```

### 2) Dictionary

#### Complexity:

- Time Complexity: ```O(n)```
- Space Complexity: ```O(n)```
- Auxiliary Space Complexity: ```O(n)```

#### Explanation:

- Iterate over every element in `nums`.
- If it has **not** been seen yet, save it in dictionary with its index.
- Else if it has been seen before, check the absolute distance between their indices.
- If distance is less or equal than `k`, we return true.
- Otherwise update this value's index to `i`.
- If we never return true inside the loop, we return false.

```cs
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
```
