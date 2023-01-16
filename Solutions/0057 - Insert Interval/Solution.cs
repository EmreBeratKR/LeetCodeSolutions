namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution
    {
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
    }
}