namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution 
    {
        public int CanCompleteCircuit(int[] gas, int[] cost) 
        {
            ApplyCost(gas, cost);

            var fill = 0;
            var station = 0;
            var startingStation = station;

            while (true)
            {
                var currentStation = station % gas.Length;
                var currentProfit = gas[currentStation];

                fill += currentProfit;

                if (fill < 0)
                {
                    fill = 0;
                    station = startingStation + 1;
                    startingStation = station;
                
                    if (startingStation >= gas.Length) return -1;

                    continue;
                }

                station += 1;

                if (station < startingStation + gas.Length) continue;

                return startingStation;
            }
        }


        private void ApplyCost(int[] gas, int[] cost)
        {
            for (var i=0; i < gas.Length; i++)
            {
                gas[i] -= cost[i];
            }
        }
    }
}