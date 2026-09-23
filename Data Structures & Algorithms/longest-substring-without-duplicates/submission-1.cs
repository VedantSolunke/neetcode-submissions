public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int ans = 0, left = 0;
        var set = new HashSet<char>();
        for(int i=0; i < s.Length; i++){
            while(set.Contains(s[i])){
                set.Remove(s[left]);
                left++;
            }

            set.Add(s[i]);
            ans = Math.Max(ans, i-left+1);
        }
        
        return ans;
    }
}
