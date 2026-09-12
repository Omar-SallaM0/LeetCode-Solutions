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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry = 0) {
        if(l1 == null && l2 == null && carry == 0) return null;

	int total = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + carry;
	carry = total / 10;
	return new ListNode(total % 10,  AddTwoNumbers(l1?.next, l2?.next, carry));
    }
}

// }
// public class Linkedlist{
//     ListNode Head;
//     public bool isEmp(){
//         return Head==null;
//     }
//     public void insert(int value){
//         ListNode new_node =new ListNode();
//         new_node.val = value;
//         if(isEmp()){
//             new_node.next = null;
//             Head = new_node;
//         }
//         else{
//             new_node.next = Head;
//             Head = new_node;
//         }
//     }
//     public int count(){
//         int count=0;
//         ListNode temp=Head;
//         while(temp!=null){
//             count++;
//             temp=temp.next;
//         }
//         return count;
//     }
// }