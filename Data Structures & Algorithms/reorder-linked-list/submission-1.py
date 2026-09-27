class Solution:
    def reorderList(self, head: Optional[ListNode]) -> None:
        if not head:
            return

        nodes = []

        # Store all nodes
        curr = head
        while curr:
            nodes.append(curr)
            curr = curr.next

        # Reorder using two pointers
        left = 0
        right = len(nodes) - 1

        while left < right:
            nodes[left].next = nodes[right]
            left += 1

            if left == right:
                break

            nodes[right].next = nodes[left]
            right -= 1

        # Last node must point to None
        nodes[left].next = None