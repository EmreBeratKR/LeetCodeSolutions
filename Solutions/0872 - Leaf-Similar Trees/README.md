[leet]: https://leetcode.com/problems/leaf-similar-trees/

# [872 - Leaf-Similar Trees][leet]

## ```Easy```

Consider all the leaves of a binary tree, from left to right order, the values of those leaves form a **leaf value sequence**.

<img src="https://s3-lc-upload.s3.amazonaws.com/uploads/2018/07/16/tree.png">

For example, in the given tree above, the leaf value sequence is `(6, 7, 4, 9, 8)`.

Two binary trees are considered _leaf-similar_ if their leaf value sequence is the same.

Return `true` if and only if the two given trees with head nodes `root1` and `root2` are leaf-similar.


### Example 1:

<img src="https://assets.leetcode.com/uploads/2020/09/03/leaf-similar-1.jpg">

```
Input: root1 = [3,5,1,6,2,9,8,null,null,7,4], root2 = [3,5,1,6,7,4,2,null,null,null,null,null,null,9,8]
Output: true
```

### Example 2:

<img src="https://assets.leetcode.com/uploads/2020/09/03/leaf-similar-2.jpg">

```
Input: root1 = [1,2,3], root2 = [1,3,2]
Output: false
```

### Constraints

- The number of nodes in each tree will be in the range `[1, 200]`.
- Both of the given trees will have values in the range `[0, 200]`.


## My Solution(s)

#### Complexity:

- Time Complexity: ```O(n+k)```
- Space Complexity: ```O(n+k+m)```
- Auxiliary Space Complexity: ```O(m)```
- n: first tree's size
- k: second tree's size
- m: first tree's breadth

```cs
public bool LeafSimilar(TreeNode root1, TreeNode root2) 
{
    var values = new List<int>();
    var index = 0;
    var isSame = true;


    Traverse(root1);
    Traverse2(root2);

    return isSame && index == values.Count;


    void Traverse(TreeNode node)
    {
        if (node is null) return;

        if (node.left is null && node.right is null)
        {
            values.Add(node.val);
            return;
        }

        Traverse(node.left);
        Traverse(node.right);
    }

    void Traverse2(TreeNode node)
    {
        if (!isSame) return;

        if (node is null) return;

        if (node.left is null && node.right is null)
        {
            if (index >= values.Count)
            {
                isSame = false;
            }

            else if (values[index] != node.val)
            {
                isSame = false;
            }

            index += 1;
            return;
        }

        Traverse2(node.left);
        Traverse2(node.right);
    }
}
```
