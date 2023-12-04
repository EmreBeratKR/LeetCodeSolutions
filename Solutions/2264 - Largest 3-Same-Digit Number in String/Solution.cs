using System;

namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution 
    {
        public string LargestGoodInteger(string num)
        {
            var candidate = int.MinValue;
            var best = int.MinValue;
            var length = 0;

            for (var i = 0; i < num.Length; i++)
            {
                var digit = CharDigitToInt(num[i]);
            
                if (digit != candidate)
                {
                    candidate = digit;
                    length = 1;
                    continue;
                }

                length += 1;
            
                if (length < 3) continue;

                best = Math.Max(best, candidate);
            }

            return best >= 0 ? $"{best}{best}{best}" : "";
        }


        private int CharDigitToInt(char digit)
        {
            return digit switch
            {
                '0' => 0,
                '1' => 1,
                '2' => 2,
                '3' => 3,
                '4' => 4,
                '5' => 5,
                '6' => 6,
                '7' => 7,
                '8' => 8,
                '9' => 9,
                _ => default
            };
        }
    }
}