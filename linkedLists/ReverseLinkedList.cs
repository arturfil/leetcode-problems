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

  }


}