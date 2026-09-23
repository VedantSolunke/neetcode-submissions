class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        if len(s) <= 1:
            return len(s)
        res = 0
        left, right = 0, 0
        myset = set()
        while(right < len(s)):
            while s[right] in myset:
                myset.remove(s[left])
                left += 1

            myset.add(s[right])
            res = max(res, right-left+1)

            right +=1

        return res
        