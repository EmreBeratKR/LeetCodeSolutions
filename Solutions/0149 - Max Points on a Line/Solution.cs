using System;
using System.Collections.Generic;

namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution 
    {
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
    }
}