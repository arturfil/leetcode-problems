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

    public ListNode ReverseList(ListNode node) {
      if (node.next.next == null) return node;
      
      System.Console.WriteLine(node.val);
      return ReverseList(node.next);

  
    }
  }


}