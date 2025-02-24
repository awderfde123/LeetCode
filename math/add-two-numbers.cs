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
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode a = new ListNode(),curr = a;
        int carry = 0;
        while(l1 != null || l2 != null )
        {
            int sum = carry + (l1 !=null ? l1.val : 0) + (l2 !=null ? l2.val : 0);
            carry = sum/10;
            curr.next = new ListNode(sum%10);
            curr=curr.next;
            if(l1 !=null) l1 = l1.next;
            if(l2 !=null) l2 = l2.next;
            
        }
        if(carry>0)
        {
            curr.next = new ListNode(carry);
        }
        return a.next;
    }
}