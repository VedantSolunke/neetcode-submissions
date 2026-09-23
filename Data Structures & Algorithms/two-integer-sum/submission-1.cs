public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int, int> temp = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){
            temp[nums[i]] = i;
        }

        for(int i = 0 ; i < nums.Length; i++){
            int diff = target - nums[i];
            if(temp.ContainsKey(diff) && temp[diff] != i){
                return new int[]{i, temp[diff]};
            }
        }
        return new int[0];
    }
}
