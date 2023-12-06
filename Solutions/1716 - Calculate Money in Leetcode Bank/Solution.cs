using System;

namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution 
    {
        public int TotalMoney(int n)
        {
            return TotalMoneyWithMath(n);
        }


        private int TotalMoneyWithLoop(int n)
        {
            var week = 0;
            var day = 0;
            var money = 0;

            while (day < n)
            {
                money += (day % 7) + week + 1;

                day += 1;

                if (day % 7 != 0) continue;
            
                week += 1;
            }

            return money; 
        }

        private int TotalMoneyWithMath(int n)
        {
            var week = n / 7;
            var day = n - week * 7;
            var lastWeekSum = (day * day + day) / 2 + day * week;
            var wholeWeeksSum = (56 + 7 * (week - 1)) * week / 2;

            return wholeWeeksSum + lastWeekSum;
        }
    }
}