namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n) 
        {
            for (var i = 0; i < n; i++)
            {
                nums1[m + i] = nums2[i];
            }

            Sort(nums1);
        }


        private void Sort(int[] arr)
        {
            for (var i = 0; i < arr.Length - 1; i++)
            {
                for (var j = i; j < arr.Length; j++)
                {
                    if (arr[i] <= arr[j]) continue;
                
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }
        }
    }
}