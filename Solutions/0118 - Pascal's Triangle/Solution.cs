using System.Collections.Generic;

namespace LeetCodeSolutions.Solutions
{
    public partial class Solution
    {
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
    }
}