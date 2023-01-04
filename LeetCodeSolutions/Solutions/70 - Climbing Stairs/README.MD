[leet]: https://leetcode.com/problems/climbing-stairs/

# [70 - Climbing Stairs][leet]

## ```Easy```

- You are climbing a staircase. It takes ```n``` steps to reach the top.

- Each time you can either climb ```1``` or ```2``` steps. In how many distinct ways can you climb to the top?

### Example 1:

```
Input: n = 2
Output: 2
Explanation: There are two ways to climb to the top.
1. 1 step + 1 step
2. 2 steps
```

### Example 2:

```
Input: n = 3
Output: 3
Explanation: There are three ways to climb to the top.
1. 1 step + 1 step + 1 step
2. 1 step + 2 steps
3. 2 steps + 1 step
```

### Constraints
- ```1 <= n <= 45```

<br>

## My Solution

```cs
public int ClimbStairs(int n)
{
    var wayCount = 0;
    var maxTwoCount = n / 2;

    for (var i=0; i <= maxTwoCount; i++)
    {
        var sumOfTwos = 2 * i;
        var onesCount = n - sumOfTwos;
        var permutation = 1d;

        for (var j=1; j <= i; j++)
        {
            permutation *= (onesCount + j);
            permutation /= j;
        }

        wayCount += (int) permutation;
    }

    return wayCount;
}
```

### Performance

- Time Complexity: ```O(n^2)```
- Space Complexity: ```O(1)```
- Runtime: ```34ms``` ```Beats 53.29%```
- Memory: ```25MB``` ```Beats 87.33%```
