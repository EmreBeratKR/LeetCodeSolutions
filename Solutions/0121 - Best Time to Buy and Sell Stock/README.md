[leet]: https://leetcode.com/problems/best-time-to-buy-and-sell-stock/

# [121 - Best Time to Buy and Sell Stock][leet]

## ```Easy```

- You are given an array ```prices``` where ```prices[i]``` is the price of a given stock on the ```i^th``` day.
- You want to maximize your profit by choosing a **single day to** buy one stock and choosing a **different day in the future** to sell that stock.
- Return *the maximum profit you can achieve from this transaction*. If you cannot achieve any profit, return ```0```.

### Example 1:

```
Input: prices = [7,1,5,3,6,4]
Output: 5
```

### Example 2:

```
Input: prices = [7,6,4,3,1]
Output: 0
```

### Constraints

- ```1 <= prices.length <= 10^5```
- ```0 <= prices[i] <= 10^4```

<br>

## My Solution

```cs
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
```

### Performance

- Time Complexity: ```O(n)```
- Space Complexity: ```O(n)```
- Auxiliary Space Complexity: ```O(1)```
