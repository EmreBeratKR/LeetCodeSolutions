using System;

namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution 
    {
        public int MaxProfit(int[] prices)
        {
            var bestProfit = 0;
            var lowestPrice = prices[0];

            for (var i = 1; i < prices.Length; i++)
            {
                var profit = prices[i] - lowestPrice;

                lowestPrice = Math.Min(lowestPrice, prices[i]);
                bestProfit = Math.Max(bestProfit, profit);
            }

            return bestProfit;
        }
    }
}