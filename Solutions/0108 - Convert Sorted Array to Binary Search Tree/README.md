[leet]: https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/
[def-0]: https://www.geeksforgeeks.org/introduction-to-height-balanced-binary-tree/

# [108 - Convert Sorted Array to Binary Search Tree][leet]

## ```Easy```

- Given an integer array `nums` where the elements are sorted in **ascending order**, convert it to a **[height-balanced][def-0]** binary search tree.

### Example 1:

<img src="https://assets.leetcode.com/uploads/2021/02/18/btree1.jpg">

<pre>
    Input: nums = [-10,-3,0,5,9]
    Output: [0,-3,9,-10,null,5]
    Explanation: [0,-10,5,null,-3,null,9] is also accepted:
    <img src="https://assets.leetcode.com/uploads/2021/02/18/btree2.jpg">
</pre>

### Example 2:

<img src="https://assets.leetcode.com/uploads/2021/02/18/btree.jpg">

```
Input: nums = [1,3]
Output: [3,1]
Explanation: [1,null,3] and [3,1] are both height-balanced BSTs.
```

### Constraints

- `1 <= nums.length <= 10^4`
- `-10^4 <= nums[i] <= 10^4`
- `nums` is sorted in a **strictly increasing** order.

<br>

## My Solution

```cs
public TreeNode SortedArrayToBST(int[] nums) 
{
    if (nums.Length <= 0) return null;

    return SortedArrayToBSTNode(nums, 0, nums.Length - 1);
}


private TreeNode SortedArrayToBSTNode(int[] nums, int left, int right)
{
    if (left > right) return null;

    var middle = (left + right) / 2;
    var leftNode = SortedArrayToBSTNode(nums, left, middle -1);
    var rightNode = SortedArrayToBSTNode(nums, middle + 1, right);

    return new TreeNode(nums[middle], leftNode, rightNode);
}
```

### Performance

- Time Complexity: ```O(logn)```
- Space Complexity: ```O(n)```
- Auxiliary Space Complexity: ```O(n)```
