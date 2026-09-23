public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        
        if(nums.Length < 3) return new List<List<int>>();

        var result = new List<List<int>>();
        Array.Sort(nums);

        for(int i=0; i < nums.Length-2; i++){
            if(i !=0 && nums[i] == nums[i-1]) continue;

            twoSum(nums, i+1, result, -nums[i]);
        }
        return result;
    }

    private void twoSum(int[] nums, int k, List<List<int>> result, int target){
        int i=k, j=nums.Length-1;
        while(i < j){
            if(nums[i] + nums[j] > target){
                j--;
            }
            else if( nums[i] + nums[j] < target){
                i++;
            }
            else{
                result.Add(new List<int>{-target, nums[i], nums[j]});
                while(i < j && nums[i] == nums[i+1]) i++;
                while(i < j && nums[j] == nums[j-1]) j--;
                i++;
                j--;
            }

        }
    }

}
