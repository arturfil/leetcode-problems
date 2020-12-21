namespace BinaryTrees {

    public class Symmetric {

        /** 
            This is for testing purposes
        + ==================================================== +
        | var head = new BinaryTreeNode();                     |    
        | head.left = new BinaryTreeNode(3);                   |        
        | head.right = new BinaryTreeNode(3);                  |         
        | head.right.left = new BinaryTreeNode(5);             |             
        | head.right.right = new BinaryTreeNode(6);            |                 
        | head.left.right = new BinaryTreeNode(5);             |             
        | head.left.left = new BinaryTreeNode(6);              |             
        |                                                      |
        | var test = new Symmetric();                          |
        | System.Console.WriteLine( test.IsSymmetric(head) );  |                         
        + ==================================================== +                         
        */

        // we make use of the general Binary Tree Node class
        public bool IsSymmetric(BinaryTreeNode node) {
            return isMirror(node, node);
        }

        private bool isMirror(BinaryTreeNode t1, BinaryTreeNode t2) {
            if (t1 == null && t2 == null) 
                return true; // this accounts for both being null therefore having only a root is symmetric
            if (t1 == null || t2 == null) 
                return false; // this accoutns for the case where only one sub root is null => not symmetric;

            return (t1.val == t2.val)
                && isMirror(t1.right, t2.left)
                && isMirror(t1.left, t2.right);
        }

    }

}