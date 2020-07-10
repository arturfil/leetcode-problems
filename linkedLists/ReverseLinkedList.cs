namespace algorithms {

  /**
    Example:
    Input: 1->2->3->4->5->NULL
    Output: 5->4->3->2->1->NULL

    Follow up:
    A linked list can be reversed either iteratively or recursively. Could you implement both?

    - The idea behind reversing a linked-list is that you basically change direction of the pointers or more like
    - the current.next = current; && current = current.next; 
    - Just like in sorting you can create a temporary placeholder in order to make the swap between the two nodes.
  */

  public class ReverseLinkedList {

    public Node ReverseList(Node head) {
      Node node1 = new Node(1);
      return head;
    }

    public void print() {
      System.Console.WriteLine("Testing that this works");
    }    

  }

  public class ListNode {
    public int val;
    public ListNode next;
    // constructor
    public ListNode(int val = 0, ListNode next = null) {
      this.val = val;
      this.next = next;
    }

    public ListNode PrintNodes(ListNode node) {
      System.Console.Write($"[{node.val}]->");
      if (node.next == null) return node;
      return PrintNodes(node.next);
    }

    public ListNode ReverseList(ListNode head) {
      // ITERATIVE METHOD
      /*
        - Here we are using a temporary variable method.
        - First we create a Node variable called previous.
        This variable will help to assing the node.next as our "future" previous node.
        then our current node or "head" will be now the node.next.
        - This way we succesfully swap node with node.next using nextTemp;
        - Every round you assing nextTemp = head.next; when nextTemp = null -> the loop will break.
      */
      ListNode prev = null;
      while(head != null) {
        ListNode nextTemp = head.next;
        head.next = prev ; 
        prev = head; 
        head = nextTemp; 
      }

      return prev;
    }

    // RECURSIVE METHOD
    // Here we are basically 
    public ListNode reverseList(ListNode head) {
      if (head == null || head.next == null) return head;
      ListNode p = reverseList(head.next); // we have to do this because the value that we take of 'head' is taken before head.next is assigned to null;
      head.next.next = head;
      head.next = null;
      return p;
    }
  }


}