class Solution:
    def checkInclusion(self, s1: str, s2: str) -> bool:

        n = len(s1)
        m = len(s2)

        if n > m:
            return False

        s1freq = [0] * 26
        s2freq = [0] * 26

        for c in s1:
            s1freq[ord(c) - ord('a')] += 1

        left= 0
        for right in range(m):
            s2freq[ ord(s2[right]) - ord('a')] += 1

            if right - left + 1 > n:
                s2freq[ ord(s2[left]) - ord('a')] -= 1
                left+=1

            if s1freq == s2freq:
                return True
        
        return False