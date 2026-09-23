public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int n = s1.Length;
        int m = s2.Length;

        if(n > m) return false;

        int[] s1Freq = new int[26];
        int[] s2Freq = new int[26];

        foreach(char c in s1){
            s1Freq[c - 'a']++;
        }

        int left = 0;
        int right = 0;


        while(right < m){
            s2Freq[s2[right]-'a']++;

            if(right-left+1 > n){
                s2Freq[s2[left]-'a']--;
                left++;
            }
            if(s1Freq.SequenceEqual(s2Freq)) return true;
            right++;
        }

        return false;
    }
}
