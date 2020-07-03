using System;

namespace algorithms {

  public class Node {
    public int data;
    public Node left, right;

    public Node(int item) {
      data = item;
      left = right = null; // we initialize an empty tree
    }
  }

  /**
    - In this class we are creating the method max depth where we check 
    each Node and it's child Nodes
    - We know we have reached the max height when a node has a null child
    - The max height is determined by checking whether one Node is bigger than the other as shown here
    - IN order to check the Max Depth we use a recursive method
  */
  
  public class BinaryTree {
    public Node root;
    
    public int maxDepth(Node node) {
      if (node == null)
        return 0;
      int left = maxDepth(node.left);
      int right = maxDepth(node.right);
      return Math.Max(left,right);
    }
  }
    
}