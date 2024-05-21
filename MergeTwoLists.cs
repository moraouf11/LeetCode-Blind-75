/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
// You are given the heads of two sorted linked lists list1 and list2.
// Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.
// Return the head of the merged linked list.
    
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        if(l1 == null)
        return l2;
        if(l2 == null)
        return l1;

        if(l1.val > l2.val )
        {
            l2.next = MergeTwoLists(l1, l2.next);
            return l2;
        }
        else
        {
            l1.next = MergeTwoLists(l2, l1.next);
            return l1;
        }
    }
}
