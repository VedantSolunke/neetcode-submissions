# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def diameterOfBinaryTree(self, root: Optional[TreeNode]) -> int:
        if root is None:
            return 0
        result = [0]
        self.diameter(root,result)
        return result[0]
        
    def diameter(self, root, result):
        if root is None:
            return 0
        
        left = self.diameter(root.left, result)
        right = self.diameter(root.right, result)

        result[0] = max(result[0], left + right)

        return max(left, right) + 1