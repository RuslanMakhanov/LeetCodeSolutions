public class Solution {
    public bool IsPalindrome(int x) {
        string original = x.ToString();
        string reversed = string.Empty;
        for (int i = original.Length - 1; i >= 0; i--)
        {
            reversed += original[i];
        }
        if (reversed == original){
            return true;
        }
        return false;
    }
}