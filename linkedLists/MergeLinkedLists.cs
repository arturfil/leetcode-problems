namespace algorithms {

  /*
      Merge two sorted linked lists and return it as a new sorted list. 
      The new list should be made by splicing together the nodes of the first two lists.
      Example:
      Input: 1->2->4, 1->3->4
      Output: 1->1->2->3->4->4
  */
  /**
    // TESTING RESOURCES IN MAINCLASS.CS
    MNode head1 = new MNode(1);
    MNode node1 = new MNode(2);
    MNode node2 = new MNode(4);
    MNode head2 = new MNode(1);
    MNode node3 = new MNode(3);
    MNode node4 = new MNode(4);
    
    // linked list 1
    head1.next = node1;
    node1.next = node2;
    // linked list 2
    head2.next = node3;
    node3.next = node4;

    head1.printLinkedList(head1);
    System.Console.WriteLine();
    head2.printLinkedList(head2);

    head1.mergeLinkedLists(head1, head2);
    System.Console.WriteLine("\n");
    head1.printLinkedList(head1);
  */

  public class MNode {
    public int val;
    public MNode next;
    // constructor
    public MNode(int val=0, MNode next=null) {
      this.val = val;
      this.next = next;
    }

    public int printLinkedList(MNode head) {
      MNode current = head;
      System.Console.Write($"[{current.val}] ->");
      if (head.next == null)
        return 0;
      return printLinkedList(head.next);
    }


    // Input: 1->2->4, 1->3->4 
    public MNode mergeLinkedLists(MNode head1, MNode head2) { 
      if (head1 == null) return head2;
      else if (head2 == null) return head1;
      else if (head1.val < head2.val) {
        head1.next = mergeLinkedLists(head1.next, head2);
        return head1;
      } else {
        head2.next = mergeLinkedLists(head1, head2.next);
        return head2;
      }
    }
  }

}