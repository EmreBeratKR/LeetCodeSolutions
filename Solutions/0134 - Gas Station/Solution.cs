namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution 
    {
        public int CanCompleteCircuit(int[] gas, int[] cost) 
        {
            var maxIndex = gas.Length - 1;
            var fill = gas[maxIndex] - cost[maxIndex];
            var maxFill = fill;

            for (int i = gas.Length - 2; i >= 0; i--)
            {
                fill += gas[i] - cost[i];

                if (fill > maxFill)
                {
                    maxFill = fill;
                    maxIndex = i;
                }
            }

            if (fill < 0) return -1;

            return maxIndex;
        }
    }
}