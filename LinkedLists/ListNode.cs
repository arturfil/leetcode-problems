namespace LinkedLists {

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

  }

}