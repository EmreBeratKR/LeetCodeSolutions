[leet]: https://leetcode.com/problems/calculate-money-in-leetcode-bank/

# [1716 - Calculate Money in Leetcode Bank][leet]

## ```Easy```

- Hercy wants to save money for his first car. He puts money in the Leetcode bank **every day**.
- He starts by putting in `$1` on Monday, the first day. Every day from Tuesday to Sunday, he will put in `$1` more than the day before. On every subsequent Monday, he will put in `$1` more than the **previous Monday**.
- Given `n`, return _the total amount of money he will have in the Leetcode bank at the end of the `nth` day._

### Example 1:

```
Input: n = 4
Output: 10
Explanation: After the 4th day, the total is 1 + 2 + 3 + 4 = 10.
```

### Example 2:

```
Input: n = 10
Output: 37
Explanation: After the 10th day, the total is (1 + 2 + 3 + 4 + 5 + 6 + 7) + (2 + 3 + 4) = 37. Notice that on the 2nd Monday, Hercy only puts in $2.
```

### Example 3:
```
Input: n = 20
Output: 96
Explanation: After the 20th day, the total is (1 + 2 + 3 + 4 + 5 + 6 + 7) + (2 + 3 + 4 + 5 + 6 + 7 + 8) + (3 + 4 + 5 + 6 + 7 + 8) = 96.
```

### Constraints

- `1 <= n <= 1000`


## My Solution(s)

### 1) Loop

#### Complexity:

- Time Complexity: ```O(n)```
- Space Complexity: ```O(1)```
- Auxiliary Space Complexity: ```O(1)```

#### Explanation:

- Loop until day counter reaches n.
- Increment money by current day's number.
- Also increment money by week index;
- Increment day by 1.
- If day is multiple of 7 increment week.
- Return money counter.

```cs
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
```

### 2) Math

#### Complexity:

- Time Complexity: ```O(1)```
- Space Complexity: ```O(1)```
- Auxiliary Space Complexity: ```O(1)```

#### Explanation:

- Calculate whole week count by dividing n by 7 as integer division operation.
- Calculate extra day count by subtracting whole week count times 7 from n.
- Calculate last week's money sum by using gauss sum.
- Calculate whole week's money sum by using gauss sum.
- Return last week's money sum + whole week's money sum.

```cs
private int TotalMoneyWithMath(int n)
{
    var week = n / 7;
    var day = n - week * 7;
    var lastWeekSum = (day * day + day) / 2 + day * week;
    var wholeWeeksSum = (56 + 7 * (week - 1)) * week / 2;

    return wholeWeeksSum + lastWeekSum;
}
```
