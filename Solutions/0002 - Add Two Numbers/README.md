[leet]: https://leetcode.com/problems/add-two-numbers/

# [2 - Two Sum][leet]

## ```Medium```

- You are given two **non-empty** linked lists representing two non-negative integers.
- The digits are stored in **reverse order**, and each of their nodes contains a single digit.
- Add the two numbers and return the sum as a linked list. 
- You may assume the two numbers do not contain any leading zero, except the number 0 itself.

### Example 1:

<img src="https://assets.leetcode.com/uploads/2020/10/02/addtwonumber1.jpg">

```
Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [7,0,8]
Explanation: 342 + 465 = 807.
```

### Example 2:

```
Input: l1 = [0], l2 = [0]
Output: [0]
```

### Example 3:
```
Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
Output: [8,9,9,9,0,0,0,1]
```

### Constraints
- The number of nodes in each linked list is in the range ```[1, 100]```.
- ```0 <= Node.val <= 9```
- It is guaranteed that the list represents a number that does not have leading zeros.

<br>

## My Solution

```cs
public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
{
    var nodeOne = l1;
    var nodeTwo = l2;

    if (nodeOne.GetLength() < nodeTwo.GetLength())
    {
        (nodeOne, nodeTwo) = (nodeTwo, nodeOne);
    }

    var start = nodeOne;
    var sum = 0;

    while (true)
    {
        sum = sum > 9 ? 1 : 0;
        sum += nodeOne.val;
        sum += nodeTwo == null ? 0 : nodeTwo.val;
        nodeOne.val = sum > 9 ? sum - 10 : sum;

        if (nodeOne.next == null)
        {
            if (sum > 9)
            {
                nodeOne.next = new ListNode(1);
            }

            return start;
        }

        nodeOne = nodeOne.next;

        if (nodeTwo == null) continue;

        nodeTwo = nodeTwo.next;
    }
}


public static class ListNodeExtensions
{
    public static int GetLength(this ListNode node)
    {
        var length = 0;
        var currentNode = node;

        while (currentNode != null)
        {
            length += 1;
            currentNode = currentNode.next;
        }

        return length;
    }
}
```

### Performance

- Time Complexity: ```O(n)```
- Space Complexity: ```O(n)```
- Auxiliary Space Complexity: ```O(n)```
