namespace EmreBeratKR.LeetCodeSolutions
{
    public partial class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            if (haystack.Length < needle.Length) return -1;
            
            for (var i = 0; i < haystack.Length; i++)
            {
                var isValid = true;

                if (haystack.Length - i < needle.Length) return -1;

                for (var j = 0; j < needle.Length; j++)
                {
                    if (haystack[i + j] == needle[j]) continue;
                    
                    isValid = false;
                    break;
                }
                
                if (!isValid) continue;

                return i;
            }

            return -1;
        }
    }
}