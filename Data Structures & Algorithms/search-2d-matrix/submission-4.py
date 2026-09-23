class Solution:
    def searchMatrix(self, matrix: List[List[int]], target: int) -> bool:
        for row in matrix:
            if self.binaryS(row, target):
                return True
        return False


    def binaryS(self, nums: List[int], target: int) -> bool:
        left = 0
        right = len(nums)-1

        while(left <= right):
            mid = left + (right-left)//2
            if(nums[mid] == target):
                return True
            elif nums[mid] > target:
                right = mid-1
            else:
                left = mid+1
        
        return False

        