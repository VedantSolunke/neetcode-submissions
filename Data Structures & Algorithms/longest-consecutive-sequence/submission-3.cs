public class Solution {
    public int LongestConsecutive(int[] nums) {
       var map = new Dictionary<int, bool>();
       foreach(int n in nums){
         map[n] = false;
       }

       int maxLength = 0;
        foreach(int num in nums){
            int currLen = 1;

            int nextNum = num+1;
            while(map.ContainsKey(nextNum) && map[nextNum] == false){
                currLen++;
                map[nextNum] = true;
                nextNum++;
            }

            int prevNum = num-1;
            while(map.ContainsKey(prevNum) && map[prevNum]  == false){
                currLen++;
                map[prevNum] = true;
                prevNum--;
            }

            maxLength = Math.Max(maxLength, currLen);
        }
       return maxLength;
    }
}
