public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new ();
        for (int i = 0; i < nums.Length; i++) {
            int cur = nums[i];
            int x = target - cur;
            if (map.ContainsKey(x)) {
                return new int[] { map[x], i };
            }
            map[cur] = i;
        }
        return null;
    }
}