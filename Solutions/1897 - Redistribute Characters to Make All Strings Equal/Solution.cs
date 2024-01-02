using System.Collections.Generic;

namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution 
    {
        public bool MakeEqual(string[] words)
        {
            var frequency = new Dictionary<char, int>();

            for (var i = 0; i < words.Length; i++)
            {
                for (var j = 0; j < words[i].Length; j++)
                {
                    var letter = words[i][j];

                    if (frequency.ContainsKey(letter))
                    {
                        frequency[letter] += 1;
                        continue;
                    }

                    frequency[letter] = 1;
                }
            }

            foreach (var pair in frequency)
            {
                if (pair.Value % words.Length != 0) return false;
            }

            return true;
        }
    }
}
