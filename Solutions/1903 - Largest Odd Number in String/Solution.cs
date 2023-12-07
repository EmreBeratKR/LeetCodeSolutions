namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution 
    {
        public string LargestOddNumber(string num)
        {
            for (var i = num.Length - 1; i >= 0; i--)
            {
                if (IsOddChar(num[i])) return num.Substring(0, i + 1);
            }

            return "";
        }
        
        
        private bool IsOddChar(char digit)
        {
            return digit switch
            {
                '1' => true,
                '3' => true,
                '5' => true,
                '7' => true,
                '9' => true,
                _ => false
            };
        }
    }
}
