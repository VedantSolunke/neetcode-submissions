public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int product = 1;
        int containsZero = 0;
        
        for(int i=0; i < nums.Length; i++){
            if(nums[i] != 0){
                product *= nums[i];
            }
            else{
                containsZero++;
            }
        }

        int[] res = new int[nums.Length];

        for(int i=0; i < nums.Length; i++){
            if(containsZero == 1){
                if(nums[i] != 0) res[i] = 0;
                else res[i] = product;
            }
            else if (containsZero > 1) {
                res[i]=0;
            }
            else{
                res[i] = product/nums[i];
            }
        }

        return res;
    }
}
