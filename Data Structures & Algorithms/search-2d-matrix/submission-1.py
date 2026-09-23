class Solution:
    def searchMatrix(self, matrix: List[List[int]], target: int) -> bool:
        oleft , oright = 0, len(matrix)-1
        while(oleft <= oright):
            omid = oleft + (oright-oleft) // 2
            if(matrix[omid][0] <= target <= matrix[omid][len(matrix[0])-1] ): 
                left , right= 0, len(matrix[0]) -1
                while(left <= right):
                    mid = left+(right-left)//2
                    if(matrix[omid][mid] == target): 
                        return True
                    elif(matrix[omid][mid] > target):
                        right = mid-1
                    else:
                        left = mid+1
                return False
                
            elif matrix[omid][0] > target:
                oright = omid - 1
            else:
                oleft = omid+1
        return False
        