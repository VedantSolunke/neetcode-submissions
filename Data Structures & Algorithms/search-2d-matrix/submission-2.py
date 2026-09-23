class Solution:
    def searchMatrix(self, matrix: List[List[int]], target: int) -> bool:

        row = 0
        col = len(matrix[0])-1

        while(col >= 0 and row < len(matrix)):
            if(matrix[row][col] == target):
                return True
            elif(target > matrix[row][col]):
                row += 1
            else:
                col -= 1
        
        return False

        