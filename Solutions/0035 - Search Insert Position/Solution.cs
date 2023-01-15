namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution
    {
        public int SearchInsert(int[] nums, int target) 
        {
            var left = 0;
            var right = nums.Length - 1;

            while (true)
            {
                if (left == right)
                {
                    if (nums[left] == target) return left;

                    break;
                }

                var middle = (right + left) / 2;

                if (target > nums[middle])
                {
                    left = left == middle ? right : middle;
                    continue;
                }

                if (target < nums[middle])
                {
                    right = middle;
                    continue;
                }

                return middle;
            }   

            if (left == 0)
            {
                if (nums.Length != 1) return 0;

                return target > nums[0] ? 1 : 0;
            }

            if (left == nums.Length - 1) return nums.Length + (target > nums[left] ? 0 : -1);

            return left;
        }
    }
}