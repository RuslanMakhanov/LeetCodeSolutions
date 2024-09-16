class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        for (int num =0; num < std::size(nums); num++){
            for(int num2= num+ 1; num2<std::size(nums); num2++){
                if (nums[num] + nums[num2] == target){
                            return {num,num2};
                }
            }
        }
        return {};
    }
};