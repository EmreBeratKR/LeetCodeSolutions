[leet]: https://leetcode.com/problems/summary-ranges/

# [228 - Summary Ranges][leet]

## ```Easy```

- You are given a **sorted unique** integer array `nums`.
- A **range** `[a,b]` is the set of all integers from `a` to `b` (inclusive).
- Return _the **smallest sorted** list of ranges that **cover all the numbers in the array exactly**_. That is, each element of `nums` is covered by exactly one of the ranges, and there is no integer `x` such that `x` is in one of the ranges but not in `nums`.
- Each range `[a,b]` in the list should be output as:
  - `"a->b"` if `a != b`
  - `"a"` if `a == b`

### Example 1:

```
Input: nums = [0,1,2,4,5,7]
Output: ["0->2","4->5","7"]
Explanation: The ranges are:
[0,2] --> "0->2"
[4,5] --> "4->5"
[7,7] --> "7"
```

### Example 2:

```
Input: nums = [0,2,3,4,6,8,9]
Output: ["0","2->4","6","8->9"]
Explanation: The ranges are:
[0,0] --> "0"
[2,4] --> "2->4"
[6,6] --> "6"
[8,9] --> "8->9"
```

### Constraints

- `0 <= nums.length <= 20`
- `-23^1 <= nums[i] <= 23^1 - 1`
- All the values of `nums` are **unique**.
- `nums` is sorted in ascending order.


## My Solution(s)

### 1) Sliding Window

#### Complexity:

- Time Complexity: ```O(n)```
- Space Complexity: ```O(n)```
- Auxiliary Space Complexity: ```O(n)```

#### Explanation:

- Create an empty string list named `ranges`.
- if `nums` is **empty** return `ranges` **immediately**.
- Else create range `[a,b]` as `[0,1]`.
- if `b >= nums.Length` add `[a,b]` to `ranges` and break the loop.
- if **index difference** is equal to **value difference**, increment `b` and continue.
- Else add range `[a,b]` to `ranges` and set value `a` as `b`, increment b and continue.
- After exited the loop return `ranges`.

```cs
private IList<string> SummaryRangesWithSlidingWindow(int[] nums)
{
    var ranges = new List<string>();

    if (nums.Length <= 0) return ranges;
    
    var a = 0;

    for (var b = 1; ; b++)
    {
        if (b >= nums.Length)
        {
            ranges.Add(ToRange(nums, a, b - 1));
            break;
        }
        
        var deltaIndex = b - a;
        var deltaValue = nums[b] - nums[a];
            
        if (deltaIndex == deltaValue) continue;

        ranges.Add(ToRange(nums, a, b - 1));
        a = b;
    }

    return ranges;
}

private string ToRange(int[] nums, int a, int b)
{
    return a == b ? nums[a].ToString() : $"{nums[a]}->{nums[b]}";
}
```
