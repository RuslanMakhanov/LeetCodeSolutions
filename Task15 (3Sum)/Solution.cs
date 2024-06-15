public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums); // Sort the array to help easily avoid duplicates and simplify the sum zero check
        List<IList<int>> triple = new List<IList<int>>();

        for (int x = 0; x < nums.Length - 2; x++) {
            // Skip duplicate values
            if (x > 0 && nums[x] == nums[x - 1]) continue;

            int a = x + 1; // Start 'a' right after 'x'
            int i = nums.Length - 1; // Start 'i' from the end of the array

            while (a < i) {
                int sum = nums[x] + nums[a] + nums[i];
                if (sum == 0) {
                    triple.Add(new List<int> { nums[x], nums[a], nums[i] });
                    a++; // Move the left pointer right
                    i--; // Move the right pointer left

                    // Skip duplicate values
                    while (a < i && nums[a] == nums[a - 1]) a++;
                    while (a < i && nums[i] == nums[i + 1]) i--;
                } else if (sum < 0) {
                    // If the sum is less than zero, move the 'a' pointer to increase the sum
                    a++;
                } else {
                    // If the sum is more than zero, move the 'i' pointer to decrease the sum
                    i--;
                }
            }
        }
        return triple;
    }
}