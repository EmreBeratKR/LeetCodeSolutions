using System.Collections.Generic;

namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution
    {
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
    }
}