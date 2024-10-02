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
        ListNode l3 = new ListNode(0);
        ListNode finalOutput = l3;

        int carry = 0;

         int x = 0;
         int y = 0;

         int totalSum = 0;

        while (l1 !=null || l2 != null)
        {
            x = (l1 != null) ? l1.val :0;
            y = (l2 != null) ? l2.val : 0;

            totalSum = x + y + carry;

            carry = totalSum / 10;

            l3.next = new ListNode(totalSum % 10);

            l3 = l3.next;

            if(l1 != null) l1 =l1.next;
            if(l2 != null) l2 =l2.next;
    
        }
        if(carry > 0 )
        {
            l3.next = new ListNode(carry);
        }
        return finalOutput.next;
    }
}