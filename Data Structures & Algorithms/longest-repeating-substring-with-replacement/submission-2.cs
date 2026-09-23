public class Solution {
    public int CharacterReplacement(string s, int k) {
        int maxWindow = 0;
        int maxFreq = 0;
        int left = 0;
        int[] freq = new int[26];

        for(int right = 0; right < s.Length; right++){
            freq[s[right] - 'A']++;

            maxFreq = Math.Max(maxFreq, freq[s[right]-'A']);

            int windowLength = right-left+1;

            if(windowLength - maxFreq > k){
                freq[s[left]-'A']--;
                left++;
            } 
            windowLength = right-left+1;
            maxWindow = Math.Max(maxWindow, windowLength);
        }


        return maxWindow;
    }
}
