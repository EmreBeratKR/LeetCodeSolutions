[leet]: https://leetcode.com/problems/max-points-on-a-line/

# [149 - Max Points on a Line][leet]

## ```Hard```

- Given an array of ```points``` where ```points[i] = [xi, yi]``` represents a point on the **X-Y** plane, return the maximum number of points that lie on the same straight line.

### Example 1:

<img src="https://assets.leetcode.com/uploads/2021/02/25/plane1.jpg">

```
Input: points = [[1,1],[2,2],[3,3]]
Output: 3
```

### Example 2:

<img src="https://assets.leetcode.com/uploads/2021/02/25/plane2.jpg">

```
Input: points = [[1,1],[3,2],[5,3],[4,1],[2,3],[1,4]]
Output: 4
```

### Constraints

- ```1 <= points.length <= 300```
- ```points[i].length == 2```
- ```-10^4 <= xi, yi <= 10^4```
- All the ```points``` are **unique**.

<br>

## My Solution

```cs
public int MaxPoints(int[][] points) 
{
    if (points.Length <= 2) return points.Length;

    var lines = new List<Line>();

    for (var i=0; i < points.Length - 1; i++)
    {
        for (var j=i + 1; j < points.Length; j++)
        {
            lines.Add(new Line(points[i], points[j]));
        }
    }

    var best = 0;

    for (var i=0; i < lines.Count; i++)
    {
        var count = 0;
        var line = lines[i];

        for (var j=0; j < points.Length; j++)
        {
            var point = points[j];
        
            if (!line.Intersects(point)) continue;

            count += 1;
        }

        if (count < best) continue;

        best = count;
    }

    return best;
}


private readonly struct Line
{
    private readonly double a;
    private readonly double b;
    private readonly bool isVertical;


    public Line(int[] pointOne, int[] pointTwo)
    {
        var deltaX = pointTwo[0] - pointOne[0];
        var deltaY = pointTwo[1] - pointOne[1];

        isVertical = deltaX == 0;

        a = isVertical
            ? (double) deltaX / deltaY
            : (double) deltaY / deltaX;

        b = isVertical
            ? pointOne[0] - a * pointOne[1]
            : pointOne[1] - a * pointOne[0];
    }


    public bool Intersects(int[] point)
    {               
        return isVertical
            ? Math.Abs(Evaluate(point[1]) - point[0]) < 0.000001
            : Math.Abs(Evaluate(point[0]) - point[1]) < 0.000001;
    }


    private double Evaluate(int x)
    {
        return a * x + b;
    }
}
```

### Performance

- Time Complexity: ```O(n^3)```
- Space Complexity: ```O(n^2)```
