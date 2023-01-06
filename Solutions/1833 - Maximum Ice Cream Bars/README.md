[leet]: https://leetcode.com/problems/maximum-ice-cream-bars/

# [1833 - Two Sum][leet]

## ```Medium```

- It is a sweltering summer day, and a boy wants to buy some ice cream bars.

- At the store, there are ```n``` ice cream bars.

- You are given an array ```costs``` of length ```n```, where ```costs[i]``` is the price of the ```ith``` ice cream bar in coins.

- The boy initially has ```coins``` coins to spend, and he wants to buy as many ice cream bars as possible.

- Return the **maximum** number of ice cream bars the boy can buy with ```coins``` coins.

- **Note:** The boy can buy the ice cream bars in any order.

### Example 1:

```
Input: costs = [1,3,2,4,1], coins = 7
Output: 4
Explanation: The boy can buy ice cream bars at indices 0,1,2,4 for a total price of 1 + 3 + 2 + 1 = 7.
```

### Example 2:

```
Input: costs = [10,6,8,7,7,8], coins = 5
Output: 0
Explanation: The boy cannot afford any of the ice cream bars.
```

### Example 3:
```
Input: costs = [1,6,3,1,2,5], coins = 20
Output: 6
Explanation: The boy can buy all the ice cream bars for a total price of 1 + 6 + 3 + 1 + 2 + 5 = 18.
```

### Constraints
- ```costs.length == n```
- ```1 <= n <= 10^5```
- ```1 <= costs[i] <= 10^5```
- ```1 <= coins <= 10^8```

<br>

## My Solution

```cs
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
```

### Performance

- Time Complexity: ```O(nlog(n))```
- Space Complexity: ```O(n)```
