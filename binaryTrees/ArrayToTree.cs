namespace algorithms {

  public class TNode {
    public int val;
    public TNode left;
    public TNode right;
    // constructor
    public TNode(int val = 0, TNode left = null, TNode right = null) {
      this.val = val;
      this.left = left;
      this.right = right;
    }

    public bool IsSymmetryc(TNode root) {
        
        
        
        return false;
    }

    public TNode convertToTree(int[] arr) {
      if (arr.Length == 0) return null;
      return constructTreeFromArray(arr, 0, arr.Length-1); // here you are putting the indexes not the vlaues themselves!
    }

    public TNode constructTreeFromArray(int[] arr, int left, int right) {
      if (left > right) return null;
      int midpoint = left + (right-left) / 2;
      TNode node = new TNode(arr[midpoint]);
      System.Console.WriteLine(arr[midpoint]);
      node.left = constructTreeFromArray(arr, left, midpoint-1);   // here you are recursively assigning the left side
      node.right = constructTreeFromArray(arr, midpoint+1, right); // here you are recursively assigning the right side

      return node;
    }

    public void printBT(TNode root, int space) {
      if (root == null) return;
    }

  }

  // Describe it in words
  /*
    NOTE: think about a recursive solution.
    Step 1 - set the parent node which will be the 2nd element.
    - we will switch the 0th with the 2nd
    Step 2 - go through the next level
    - compare arr[i] to parent node if arr[i] > parent then goes on the right;
  */
//   public class ArrayToTree {
//     // [-10, -3, 0, 5, 9]

//     public TNode convertToTree(int[] arr) {
//       if (arr.Length == 0) return null;
//       return constructTreeFromArray(arr, 0, arr.Length-1); // here you are putting the indexes not the vlaues themselves!
//     }

//     public TNode constructTreeFromArray(int[] arr, int left, int right) {
//       if (left > right) return null;
//       int midpoint = left + (right-left) / 2;
//       TNode node = new TNode(arr[midpoint]);
//       System.Console.WriteLine(arr[midpoint]);
//       node.left = constructTreeFromArray(arr, left, midpoint-1);   // here you are recursively assigning the left side
//       node.right = constructTreeFromArray(arr, midpoint+1, right); // here you are recursively assigning the right side

//       return node;
//     }

//     public void printBT(TNode root, int space) {
//       if (root == null) return;
//     }

//   }

}