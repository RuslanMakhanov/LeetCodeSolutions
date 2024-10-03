public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int maxLength = 0;
        int left = 0;
        int right = 0;
        HashSet<char> charSet = new();

        while(right <s.Length)
        {
            if (!charSet.Contains(s[right]))
            {
                charSet.Add(s[right]);
                right++;
                maxLength = Math.Max(maxLength, right-left);
            }
            else
            {
                charSet.Remove(s[left]);
                left++;
            }
        }
        return maxLength;
    }
}