public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0) return 0; // Edge case for empty array
        
        int k = 1; // Start from the second element
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] != nums[i - 1]) { // If current element is not duplicate
                nums[k] = nums[i]; // Assign it to the position of k
                k++; // Increment k to move to the next unique position
            }
        }
        return k; // k is the length of array with no duplicates
    }
}