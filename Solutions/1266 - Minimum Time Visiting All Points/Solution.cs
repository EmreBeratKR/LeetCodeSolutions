using System;

namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution 
    {
        public int MinTimeToVisitAllPoints(int[][] points)
        {
            var time = 0;
            
            for (var i = 0; i < points.Length - 1; i++)
            {
                var a = points[i];
                var b = points[i + 1];
                var deltaX = Math.Abs(a[0] - b[0]);
                var deltaY = Math.Abs(a[1] - b[1]);

                time += Math.Max(deltaX, deltaY);
            }

            return time;
        }
    }
}