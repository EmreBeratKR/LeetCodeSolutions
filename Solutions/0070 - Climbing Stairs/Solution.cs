namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution 
    {
        public int ClimbStairs(int n)
        {
            var wayCount = 0;
            var maxTwoCount = n / 2;

            for (var i=0; i <= maxTwoCount; i++)
            {
                var sumOfTwos = 2 * i;
                var onesCount = n - sumOfTwos;
                var permutation = 1d;

                for (var j=1; j <= i; j++)
                {
                    permutation *= (onesCount + j);
                    permutation /= j;
                }

                wayCount += (int) permutation;
            }

            return wayCount;
        }
    }
}