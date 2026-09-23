class Solution:
    def searchMatrix(self, matrix: List[List[int]], target: int) -> bool:
        for col in matrix:
            for row in col:
                if row == target:
                    return True
        
        return False
        