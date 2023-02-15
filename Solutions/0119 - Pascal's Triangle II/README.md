[leet]: https://leetcode.com/problems/pascals-triangle-ii/

# [189 - Pascal's Triangle II][leet]

## ```Easy```

- Given an integer `rowIndex`, return the `rowIndexth` **(0-indexed)** row of the **Pascal's triangle**.

- In **Pascal's triangle**, each number is the sum of the two numbers directly above it as shown:

<img src="https://upload.wikimedia.org/wikipedia/commons/0/0d/PascalTriangleAnimated2.gif">

### Example 1:

```
Input: rowIndex = 3
Output: [1,3,3,1]
```

### Example 2:

```
Input: rowIndex = 0
Output: [1]
```

### Example 3:

```
Input: rowIndex = 1
Output: [1,1]
```

### Constraints

- `0 <= rowIndex <= 33`

<br>

## My Solution

```cs
public IList<int> GetRow(int rowIndex) 
{
    var previousRow = new int[rowIndex + 1];
    previousRow[0] = 1;

    if (rowIndex == 0) return previousRow;

    var currentRow = new int[rowIndex + 1];
    previousRow[1] = 1;

    for (var i = 2; i <= rowIndex; i++)
    {
        currentRow[0] = 1;

        for (var j = 1; j < i; j++)
        {
            currentRow[j] = previousRow[j] + previousRow[j - 1];
        }

        currentRow[i] = 1;

        (previousRow, currentRow) = (currentRow, previousRow);
    }

    return previousRow;
}
```

### Performance

- Time Complexity: ```O(n^2)```
- Space Complexity: ```O(n)```
- Auxiliary Space Complexity: ```O(n)```
