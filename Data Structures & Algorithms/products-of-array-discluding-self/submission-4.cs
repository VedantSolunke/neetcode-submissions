public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int prefix = 1;
        int[] prefixA = new int[nums.Length];
        for(int i=0; i < nums.Length; i++){
            prefixA[i] = prefix;
            prefix = prefix * nums[i];
        }

        int suffix = 1;
        int[] suffixA = new int[nums.Length];
        for(int i = nums.Length-1; i >= 0; i--){
            suffixA[i] = suffix;
            suffix = suffix * nums[i];
        }

        for(int i=0; i < nums.Length; i++){
            nums[i] = prefixA[i] * suffixA[i];
        }

        return nums;
    }
}
