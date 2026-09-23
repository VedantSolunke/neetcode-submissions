class Solution:
    def maxArea(self, heights: List[int]) -> int:
        left, right = 0, len(heights)-1
        result = 0

        while(left < right):
            minH = min(heights[left], heights[right])
            width = right-left
            area = width * minH

            result = max(result, area)

            if( heights[left] < heights[right]):
                left += 1
            else:
                right -=1
            
        return result