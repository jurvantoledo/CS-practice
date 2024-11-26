using System;
using System.Collections.Generic;

 // Definition for singly-linked list.
 public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
         this.val = val;
         this.next = next;
     }
 }
public class Solution {
    static ListNode CreateLinkedList(int[] values)
    {
        if (values.Length == 0) return null;
        
        ListNode head = new ListNode(values[0]);
        ListNode current = head;
        
        for (int i = 1; i < values.Length; i++) {
            current.next = new ListNode(values[i]);
            current = current.next;
        }
        
        return head;
    }
    
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        
        List<ListNode> allLists = new List<ListNode>();
        AddToList(allLists, list1);
        AddToList(allLists, list2);
        
         List<int> numberList = new List<int>();
         
        foreach (var node in allLists) {
             numberList.Add(node.val);
         }
         
         numberList.Sort();
         
         ListNode dummy = new ListNode();
         ListNode current = dummy;
         foreach (var number in numberList) {
             current.next = new ListNode(number);
             current = current.next;
         }
        return dummy.next;
    }
    
    static void AddToList(List<ListNode> allLists, ListNode node) {
        while (node != null) {
            allLists.Add(node);
            node = node.next;
        }
    }
    
    static void Main() {
        Solution sol = new Solution();
        ListNode list1 = CreateLinkedList(new int[] {1, 3, 4});
        ListNode list2 = CreateLinkedList(new int[] {1, 4, 6});

        List<ListNode> allLists = new List<ListNode>();

        
        sol.MergeTwoLists(list1, list2);
    }
}