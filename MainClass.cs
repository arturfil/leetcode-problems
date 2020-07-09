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

            ListNode node2 = new ListNode(6);
            ListNode node1 = new ListNode(4, node2);
            ListNode head = new ListNode(2, node1);
            head.PrintNodes(head);
            head.ReverseList(head);
            head.PrintNodes(head);

            
        }
    }

}   
