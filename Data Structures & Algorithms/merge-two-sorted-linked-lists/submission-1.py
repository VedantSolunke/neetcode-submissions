# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def mergeTwoLists(self, list1: Optional[ListNode], list2: Optional[ListNode]) -> Optional[ListNode]:
        if list1 is None:
            return list2
        if list2 is None:
            return list1

        dummyNode = ListNode(0,None)
        curr = dummyNode

        c1 = list1
        c2 = list2

        while c1 is not None and c2 is not None:
            if c1.val <= c2.val:
                curr.next = c1
                c1 = c1.next            
            else:
                curr.next = c2
                c2 = c2.next
            curr = curr.next

        if c1 is not None:
            curr.next = c1
        else:
            curr.next = c2


        return dummyNode.next