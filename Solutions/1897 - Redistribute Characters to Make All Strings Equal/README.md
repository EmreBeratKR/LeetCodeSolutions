[leet]: https://leetcode.com/problems/redistribute-characters-to-make-all-strings-equal/

# [1897 - Redistribute Characters to Make All Strings Equal][leet]

## ```Medium```

- You are given an array of strings `words` **(0-indexed)**.
- In one operation, pick two **distinct** indices `i` and `j`, where `words[i]` is a non-empty string, and move **any** character from `words[i]` to **any** position in `words[j]`.
- Return `true` _if you can make **every** string in words equal using **any** number of operations, and `false` otherwise._

### Example 1:

```
Input: words = ["abc","aabc","bc"]
Output: true
Explanation: Move the first 'a' in words[1] to the front of words[2],
to make words[1] = "abc" and words[2] = "abc".
All the strings are now equal to "abc", so return true.
```

### Example 2:

```
Input: words = ["ab","a"]
Output: false
Explanation: It is impossible to make all the strings equal using the operation.
```

### Example 3:
```
Input: costs = [1,6,3,1,2,5], coins = 20
Output: 6
Explanation: The boy can buy all the ice cream bars for a total price of 1 + 6 + 3 + 1 + 2 + 5 = 18.
```

### Constraints
- `1 <= words.length <= 100`
- `1 <= words[i].length <= 100`
- `words[i]` consists of lowercase English letters.

<br>

## My Solution

```cs
public bool MakeEqual(string[] words) 
{
    var frequency = new Dictionary<char, int>();

    for (var i = 0; i < words.Length; i++)
    {
        for (var j = 0; j < words[i].Length; j++)
        {
            var letter = words[i][j];

            if (frequency.ContainsKey(letter))
            {
                frequency[letter] += 1;
                continue;
            }

            frequency[letter] = 1;
        }
    }

    foreach (var pair in frequency)
    {
        if (pair.Value % words.Length != 0) return false;
    }

    return true;
}
```

### Performance

- Time Complexity: ```O(n*m)```
- Space Complexity: ```O(n*m)```
- Auxiliary Space Complexity: ```O(k)```
- n: word count
- m: max word length
- k: unique character count
