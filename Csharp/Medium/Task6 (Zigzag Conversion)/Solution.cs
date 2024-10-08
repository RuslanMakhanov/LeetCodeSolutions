public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1 || s.Length <= numRows) {
            return s;  // Special case when no zigzag is needed
        }

        StringBuilder result = new StringBuilder();
        int cycleLength = (numRows - 1) * 2; // The cycle for zigzag pattern

        for (int row = 0; row < numRows; row++) {
            for (int i = row; i < s.Length; i += cycleLength) {
                result.Append(s[i]);  // Append the current character
                
                int secondIndex = i + cycleLength - 2 * row;
                if (row != 0 && row != numRows - 1 && secondIndex < s.Length) {
                    result.Append(s[secondIndex]);
                }
            }
        }

        return result.ToString();
    }
}
