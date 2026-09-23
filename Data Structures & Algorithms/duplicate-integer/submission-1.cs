public class Solution {
    public bool hasDuplicate(int[] nums) {
        if(nums.Length == 0 || nums.Length == 1) return false;
        HashSet<int> tempset = new HashSet<int>();
        tempset.Add(nums[0]);
        for(int i=1; i < nums.Length; i++){
            if(tempset.Contains(nums[i])) return true;
            tempset.Add(nums[i]);
        }
        return false;
    }
}