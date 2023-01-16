[leet]: https://leetcode.com/problems/search-insert-position/

# [35 - Search Insert Position][leet]

## ```Easy```

- Given a sorted array of distinct integers and a target value, return the index if the target is found. 
- If not, return the index where it would be if it were inserted in order.
- You must write an algorithm with `O(log n)` runtime complexity.

### Example 1:

```
Input: nums = [1,3,5,6], target = 5
Output: 2
```

### Example 2:

```
Input: nums = [1,3,5,6], target = 2
Output: 1
```

### Example 3:

```
Input: nums = [1,3,5,6], target = 7
Output: 4
```

### Constraints

- `1 <= nums.length <= 10^4` 
- `-10^4 <= nums[i] <= 10^4`
- `nums` contains **distinct** values sorted in **ascending** order.
- `-10^4 <= target <= 10^4`

<br>

## My Solution

```cs
public int SearchInsert(int[] nums, int target) 
{
    var left = 0;
    var right = nums.Length - 1;

    while (true)
    {
        if (left == right)
        {
            if (nums[left] == target) return left;

            break;
        }

        var middle = (right + left) / 2;

        if (target > nums[middle])
        {
            left = left == middle ? right : middle;
            continue;
        }

        if (target < nums[middle])
        {
            right = middle;
            continue;
        }

        return middle;
    }   

    if (left == 0)
    {
        if (nums.Length != 1) return 0;

        return target > nums[0] ? 1 : 0;
    }

    if (left == nums.Length - 1) return nums.Length + (target > nums[left] ? 0 : -1);

    return left;
}
```

### Performance

- Time Complexity: ```O(log n)```
- Space Complexity: ```O(n)```
- Auxiliary Space Complexity: ```O(1)```
