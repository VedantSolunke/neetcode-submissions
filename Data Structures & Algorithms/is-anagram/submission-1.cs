public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        
        int[] alphaMap = new int[26];

        for(int i=0; i < s.Length; i++){
            alphaMap[s[i] - 'a']++;
            alphaMap[t[i] - 'a']--;
        }

        foreach(int val in alphaMap){
            if(val != 0) return false;
        }
        return true;
    }
}
