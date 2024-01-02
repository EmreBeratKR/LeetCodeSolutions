[leet]: https://leetcode.com/problems/convert-an-array-into-a-2d-array-with-conditions/

# [2610 - Convert an Array Into a 2D Array With Conditions][leet]

## ```Easy```

You are given an integer array `nums`. You need to create a 2D array from `nums` satisfying the following conditions:
- The 2D array should contain **only** the elements of the array `nums`.
- Each row in the 2D array contains **distinct** integers.
- The number of rows in the 2D array should be **minimal**.

Return the resulting array. If there are multiple answers, return any of them.

**Note** that the 2D array can have a different number of elements on each row.

### Example 1:

```
Input: nums = [1,3,4,1,2,3,1]
Output: [[1,3,4,2],[1,3],[1]]
Explanation: We can create a 2D array that contains the following rows:
- 1,3,4,2
- 1,3
- 1
All elements of nums were used, and each row of the 2D array contains distinct integers, so it is a valid answer.
It can be shown that we cannot have less than 3 rows in a valid array.
```

### Example 2:

```
Input: nums = [1,2,3,4]
Output: [[4,3,2,1]]
Explanation: All elements of the array are distinct, so we can keep all of them in the first row of the 2D array.
```

### Constraints

- `1 <= nums.length <= 200`
- `1 <= nums[i] <= nums.length`


## My Solution(s)

### 1) Index Queue

#### Complexity:

- Time Complexity: ```O(n^2)```
- Space Complexity: ```O(n)```
- Auxiliary Space Complexity: ```O(n)```

#### Explanation:

- Iterate over all numbers.
- Create the first row from this linear iteration.
- And also queue up the duplicate numbers' indices.
- After dequeue the index queue until it is emptied.
- If any of dequeued index is a duplicate send it back to queue again.
- Else add it in to the current row.
- If we reached at end of the queue add the current row to the matrix and create a new row.
- Return matrix.

```cs
public IList<IList<int>> FindMatrix(int[] nums)
{
    var matrix = new List<IList<int>>();
    var queue = new Queue<int>();
    var firstRow = new HashSet<int>();

    for (var i = 0; i < nums.Length; i++)
    {
        if (firstRow.Contains(nums[i]))
        {
            queue.Enqueue(i);
            continue;
        }

        firstRow.Add(nums[i]);
    }
    
    matrix.Add(firstRow.ToArray());

    var lastIndex = -1;
    var row = new HashSet<int>();
    
    while (queue.Count > 0)
    {
        var index = queue.Dequeue();

        if (index <= lastIndex)
        {
            matrix.Add(row.ToArray());
            row = new HashSet<int>();
        }

        lastIndex = index;

        if (row.Contains(nums[index]))
        {
            queue.Enqueue(index);
            continue;
        }

        row.Add(nums[index]);
    }

    if (row.Count > 0)
    {
        matrix.Add(row.ToArray());
    }

    return matrix;
}
```
