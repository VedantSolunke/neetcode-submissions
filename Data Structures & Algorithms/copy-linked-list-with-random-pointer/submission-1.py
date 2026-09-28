"""
# Definition for a Node.
class Node:
    def __init__(self, x: int, next: 'Node' = None, random: 'Node' = None):
        self.val = int(x)
        self.next = next
        self.random = random
"""

class Solution:
    def copyRandomList(self, head: 'Optional[Node]') -> 'Optional[Node]':
        if head is None:
            return None
        
        curr = head
        while curr:
            copycurr = Node(curr.val)
            copycurr.next = curr.next
            curr.next = copycurr
            curr = copycurr.next

        curr = head
        while curr:
            if curr.random:
                curr.next.random = curr.random.next
            curr = curr.next.next
        
        new_head = head.next
        curr = head
        new_curr = new_head

        while curr:
            curr.next = new_curr.next
            curr = curr.next

            if curr:
                new_curr.next = curr.next
                new_curr = new_curr.next

        return new_head
    
