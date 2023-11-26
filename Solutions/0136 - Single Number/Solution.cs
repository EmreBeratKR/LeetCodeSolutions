namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution 
    {
        public int SingleNumber(int[] nums)
        {
            var xor = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                xor ^= nums[i];
            }

            return xor;
        }
    }
}