namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution
    {
        public int[] PlusOne(int[] digits) 
        {
            digits[^1] += 1;
            var carry = digits[^1] > 9;

            digits[^1] -= carry ? 10 : 0;

            for (var i = digits.Length - 2; i >= 0; i--)
            {
                digits[i] += carry ? 1 : 0;

                carry = digits[i] > 9;

                if (!carry) continue;

                digits[i] -= 10;
            }

            if (carry)
            {
                var newDigits = new int[digits.Length + 1];

                newDigits[0] = 1;

                for (var i = 0; i < digits.Length; i++)
                {
                    newDigits[i + 1] = digits[i];
                }

                digits = newDigits;
            }

            return digits;
        }
    }
}