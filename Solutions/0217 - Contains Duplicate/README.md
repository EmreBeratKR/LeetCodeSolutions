[leet]: https://leetcode.com/problems/contains-duplicate/

# [217 - Contains Duplicate][leet]

## ```Easy```

- Given an integer array `nums`, return `true` if any value appears **at least twice** in the array, and return `false` if every element is distinct.

### Example 1:

```
Input: nums = [1,2,3,1]
Output: true
```

### Example 2:

```
Input: nums = [1,2,3,4]
Output: false
```

### Example 3:

```
Input: nums = [1,1,1,3,3,4,3,2,4,2]
Output: true
```

### Constraints

- `1 <= nums.length <= 10^5`
- `-10^9 <= nums[i] <= 10^9`


## My Solution(s)

### 1) Brute Force

- Time Complexity: ```O(n^2)```
- Space Complexity: ```O(n)```
- Auxiliary Space Complexity: ```O(1)```

```cs
private bool ContainsDuplicateWithBruteForce(int[] nums)
{
    for (var i = 0; i < nums.Length - 1; i++)
    {
        for (var j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] == nums[j]) return true;
        }
    }

    return false;
}
```

### 2) Sorting

- Time Complexity: ```O(nlogn)```
- Space Complexity: ```O(n)```
- Auxiliary Space Complexity: ```O(1)```

```cs
private bool ContainsDuplicateWithSorting(int[] nums)
{
    Array.Sort(nums);

    for (var i = 0; i < nums.Length - 1; i++)
    {
        if (nums[i] == nums[i + 1]) return true;
    }

    return false;
}
```

### 3) HashSet

- Time Complexity: ```O(n)```
- Space Complexity: ```O(n)```
- Auxiliary Space Complexity: ```O(n)```

```cs
private bool ContainsDuplicateWithHashSet(int[] nums)
{
    var hashSet = new HashSet<int>();

    for (var i = 0; i < nums.Length; i++)
    {
        if (hashSet.Contains(nums[i])) return true;

        hashSet.Add(nums[i]);
    }

    return false;
}
```
