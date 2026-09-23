public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int[] ans = new int[2];

        int left = 0;
        int right = numbers.Length-1;

        while(left < right && right < numbers.Length){
            if((numbers[left] + numbers[right] )== target){
                ans[0] = left+1;
                ans[1] = right+1;

                return ans;
            }
            if((numbers[left] + numbers[right] )< target){
                left++;
            }      
            if((numbers[left] + numbers[right] ) > target){
                right--;
            }
        }
        return ans;
    }
}
