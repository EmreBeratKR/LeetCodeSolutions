[leet]: https://leetcode.com/problems/pascals-triangle/

# [188 - Pascal's Triangle][leet]

## ```Easy```

- Given an integer `numRows`, return the first numRows of **Pascal's triangle**.

- In **Pascal's triangle**, each number is the sum of the two numbers directly above it as shown:

<img src="https://upload.wikimedia.org/wikipedia/commons/0/0d/PascalTriangleAnimated2.gif">

### Example 1:

```
Input: numRows = 5
Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
```

### Example 2:

```
Input: numRows = 1
Output: [[1]]
```

### Constraints

- `1 <= numRows <= 30`

<br>

## My Solution

```cs
public IList<IList<int>> Generate(int numRows) 
{
    var result = new List<IList<int>> {new List<int>(){1}};

    for (var i = 1; i < numRows; i++)
    {
        result.Add(new List<int>());

        result[i].Add(1);

        for (var j = 1; j < i; j++)
        {
            result[i].Add(result[i - 1][j - 1] + result[i - 1][j]);
        }

        result[i].Add(1);
    }

    return result;
}
```

### Performance

- Time Complexity: ```O(n^2)```
- Space Complexity: ```O(n^2)```
- Auxiliary Space Complexity: ```O(n^2)```
