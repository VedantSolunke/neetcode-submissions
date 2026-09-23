public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = new HashSet<int>(nums);
        int maxCount = 0;

        foreach(int n in set){
            if(!set.Contains(n-1)){
                int current = n;
                int length = 1;

                while(set.Contains(current+1)){
                    current++;
                    length++;
                }

                maxCount = Math.Max(maxCount, length);
            }
        }

        return maxCount;
    }
}
