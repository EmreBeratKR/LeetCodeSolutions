[leet]: https://leetcode.com/problems/insert-interval/

# [57 - Insert Interval][leet]

## ```Medium```

- You are given an array of non-overlapping intervals `intervals` where `intervals[i] = [starti, endi]` represent the start and the end of the `ith` interval and `intervals` is sorted in ascending order by `starti`. 
- You are also given an interval `newInterval = [start, end]` that represents the start and end of another interval. 
- Insert `newInterval` into `intervals` such that `intervals` is still sorted in ascending order by `starti` and `intervals` still does not have any overlapping intervals (merge overlapping intervals if necessary). 
- Return `intervals` after the insertion.

### Example 1:

```
Input: intervals = [[1,3],[6,9]], newInterval = [2,5]
Output: [[1,5],[6,9]]
```

### Example 2:

```
Input: intervals = [[1,2],[3,5],[6,7],[8,10],[12,16]], newInterval = [4,8]
Output: [[1,2],[3,10],[12,16]]
Explanation: Because the new interval [4,8] overlaps with [3,5],[6,7],[8,10].
```

### Constraints

- `0 <= intervals.length <= 10^4`
- `intervals[i].length == 2`
- `0 <= starti <= endi <= 10^5`
- `intervals` is sorted by `starti` in **ascending** order.
- `newInterval.length == 2`
- `0 <= start <= end <= 10^5`

<br>

## My Solution

```cs
public int[][] Insert(int[][] intervals, int[] newInterval) 
{
    if (intervals.Length <= 0) return new int[][]{newInterval};

    var left = 0;
    var right = 0;
    var mergeBegun = false;

    while (true)
    {
        if (right >= intervals.Length) break;

        if (TryMerge(intervals[left], mergeBegun ? intervals[right] : newInterval))
        {
            mergeBegun = true;
            right += 1;
            continue;
        }

        if (mergeBegun)
        {
            left += 1;
            intervals[left] = intervals[right];
            right += 1;
            continue;
        }

        left += 1;
        right += 1;
    }

    int[][] result;

    if (!mergeBegun)
    {
        result = new int[intervals.Length + 1][];
        var inserted = false;

        for (var i = 0; i < intervals.Length; i++)
        {
            if (!inserted && newInterval[1] < intervals[i][0])
            {
                inserted = true;
                result[i] = newInterval;
                continue;
            }

            result[i] = intervals[i + (inserted ? -1 : 0)];
        }

        result[^1] = inserted ? intervals[^1] : newInterval;

        return result;
    }

    result = new int[left + 1][];

    for (var i = 0; i < result.Length; i++)
    {
        result[i] = intervals[i];
    }

    return result;
}


private bool TryMerge(int[] target, int[] input)
{
    if (target[1] < input[0] || target[0] > input[1]) return false;

    target[0] = target[0] < input[0] ? target[0] : input[0];
    target[1] = target[1] > input[1] ? target[1] : input[1];

    return true;
}
```

### Performance

- Time Complexity: ```O(n)```
- Space Complexity: ```O(n)```
- Auxiliary Space Complexity: ```O(n)```
