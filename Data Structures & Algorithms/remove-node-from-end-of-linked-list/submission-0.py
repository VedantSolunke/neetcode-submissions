# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def removeNthFromEnd(self, head: Optional[ListNode], n: int) -> Optional[ListNode]:

        dummy = ListNode(-1)
        dummy.next = head
        firstPtr = dummy
        secondPtr = dummy

        for i in range(n):
            secondPtr = secondPtr.next
        
        while secondPtr.next:
            firstPtr = firstPtr.next
            secondPtr = secondPtr.next
        
        firstPtr.next = firstPtr.next.next

        return dummy.next
        