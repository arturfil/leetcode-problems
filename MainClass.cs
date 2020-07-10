using System;
using System.Collections.Generic;

namespace algorithms
{
    class MainClass {
        
        static void Main(string[] args) {
            // Check each class in case that you want to see solved and 
            // pending problems.
            // SolvedProblems solved = new SolvedProblems();
            // PendingProblems pending = new PendingProblems();
            // solved.print();
            // pending.print();

            // Testing Area
            // ------------ 
            ReverseLinkedList lnkList = new ReverseLinkedList(); 
            
            ListNode head = new ListNode();
            ListNode node1 = new ListNode(1);
            ListNode node2 = new ListNode(2);
            ListNode node3 = new ListNode(3);
            head.next = node1;
            node1.next = node2;
            node2.next = node3;
            head.PrintNodes(head);
            node1.reverseList(head);
            System.Console.WriteLine();
            node1.PrintNodes(node3);

            
        }
    }

}   
