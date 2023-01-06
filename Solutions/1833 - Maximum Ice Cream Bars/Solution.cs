namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution
    {
        public int MaxIceCream(int[] costs, int coins) 
        {
            QuickSort(costs);

            int count;
            for (count=0; count < costs.Length; count++)
            {
                var currentCost = costs[count];

                if (currentCost > coins) break;

                coins -= currentCost;
            }

            return count;
        }

    
        private void QuickSort(int[] array)
        {
            QuickSortStep(array, 0, array.Length - 1);
        }

        private void QuickSortStep(int[] array, int left, int right)
        {
            if (left >= right) return;

            var partition = Partition(array, left, right);
            QuickSortStep(array, left, partition -1);
            QuickSortStep(array, partition + 1, right);
        }

        private int Partition(int[] array, int left, int right)
        {
            var pivotIndex = left - 1;
            var pivot = array[right];

            for (var i=left; i < right; i++)
            {
                if (array[i] >= pivot) continue;

                pivotIndex += 1;
                (array[pivotIndex], array[i]) = (array[i], array[pivotIndex]);
            }

            pivotIndex += 1;
            (array[pivotIndex], array[right]) = (array[right], array[pivotIndex]);

            return pivotIndex;
        }
    }
}