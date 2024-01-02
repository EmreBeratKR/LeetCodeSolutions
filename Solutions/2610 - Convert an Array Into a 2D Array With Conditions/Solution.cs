using System.Collections.Generic;
using System.Linq;

namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution 
    {
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
    }
}