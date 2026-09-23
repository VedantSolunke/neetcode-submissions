public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int[] ans = new int[2];

        int left = 0, right = numbers.Length-1;

        while(left < right){
            int sum = numbers[left] + numbers[right];

            if(sum == target){
                ans[0] = left+1;
                ans[1] = right+1;
                return ans;
            }
            else if(sum > target) right--;
            else left++;
        }
        return ans;
    }
}