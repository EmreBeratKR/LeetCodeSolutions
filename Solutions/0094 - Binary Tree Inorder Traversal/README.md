[leet]: https://leetcode.com/problems/binary-tree-inorder-traversal/

# [94 - Binary Tree Inorder Traversal][leet]

## ```Easy```

- Given the `root` of a binary tree, return _the inorder traversal of its nodes' values._

### Example 1:

<img src="https://assets.leetcode.com/uploads/2020/09/15/inorder_1.jpg">

```
Input: root = [1,null,2,3]
Output: [1,3,2]
```

### Example 2:

```
Input: root = []
Output: []
```

### Example 3:
```
Input: root = [1]
Output: [1]
```

### Constraints
- The number of nodes in the tree is in the range `[0, 100]`.
- `-100 <= Node.val <= 100`

<br>

**Follow-up:** Recursive solution is trivial, could you do it iteratively?

## My Solution(s)

### 1) Recursion

#### Complexity:

- Time Complexity: ```O(n)```
- Space Complexity: ```O(n)```
- Auxiliary Space Complexity: ```O(n)```

#### Explanation:

- Recursively add values by in order.

```cs
private IList<int> InorderTraversalWithRecursion(TreeNode root)
{
    var values = new List<int>();
    
    InorderTraversalRecursionStep(root, values);

    return values;
}

private void InorderTraversalRecursionStep(TreeNode root, IList<int> values)
{
    if (root is null) return;
    
    InorderTraversalRecursionStep(root.left, values);
    values.Add(root.val);
    InorderTraversalRecursionStep(root.right, values);
}
```

### 2) Iteration

#### Complexity:

- Time Complexity: ```O(n)```
- Space Complexity: ```O(n)```
- Auxiliary Space Complexity: ```O(n)```

#### Explanation:

- If `root` is null return empty list.
- Else, create a stack called `nodeStack` and push `root` into it.
- Keep pushing left-hand-side nodes if there exists.
- If not or visited already pop current node from the `nodeStack` and add its value to `values`.
- And if right-hand-side node exists push it to `nodeStack` and continue next iteration.
- Otherwise ignore left-hand-side node next iteration as it is visited already.
- Keep iterating until `nodeStack` is empty.
- Return `values` after the iterations.

```cs
private IList<int> InorderTraversalWithIteration(TreeNode root)
{
    var values = new List<int>();
    
    if (root is null) return values;
    
    var nodeStack = new Stack<TreeNode>();
    var ignoreLeft = false;

    nodeStack.Push(root);

    while (nodeStack.Count > 0)
    {
        var currentNode = nodeStack.Peek();

        if (currentNode.left is null || ignoreLeft)
        {
            values.Add(currentNode.val);
            nodeStack.Pop();

            ignoreLeft = currentNode.right is null;
            
            if (currentNode.right is not null)
            {
                nodeStack.Push(currentNode.right);
            }
            
            continue;
        }

        nodeStack.Push(currentNode.left);
    }

    return values;
}
```
