# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def reorderList(self, head: Optional[ListNode]) -> None:

        slowp = head
        fastp = head

        while fastp and fastp.next:
            slowp = slowp.next
            fastp = fastp.next.next
        

        revh = slowp

        prev = None
        curr = revh

        while curr:
            temp = curr.next
            curr.next = prev
            prev = curr
            curr = temp
        
        revh = prev
        curr = head

        while( revh.next):
            tempcurr = curr.next
            curr.next = revh

            temprevh = revh.next
            revh.next = tempcurr

            curr = tempcurr
            revh = temprevh
        