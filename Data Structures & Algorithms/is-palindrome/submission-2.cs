public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length-1;

        while(left < right){
            if(!char.IsLetterOrDigit(s[left])){
                left++;
                continue;
            }
            if(!char.IsLetterOrDigit(s[right])){
                right--;
                continue;
            }
            char first = char.ToLower(s[left]);
            char last = char.ToLower(s[right]);
            if(first != last) return false;
            left++;
            right--;
        }
        return true;
    }
}
