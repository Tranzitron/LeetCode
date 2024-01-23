namespace LeetCode_3._Longest_Substring_Without_Repeating_Characters;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var result = 0;
        var length = s.Length;
        for (var start = 0; start < length; start++)
        for (var end = 0; end <= length - start; end++)
        {
            var str = s.Substring(start, end);
            var strLen = str.Length;
            if (strLen > result && !HasRepeatingCharacter(str)) result = strLen;
        }

        return result;
    }

    private static bool HasRepeatingCharacter(string s)
    {
        var chars = new List<char>(s.Length);
        foreach (var charAtIndex in s)
        {
            if (chars.Contains(charAtIndex)) return true;

            chars.Add(charAtIndex);
        }

        return false;
    }
}