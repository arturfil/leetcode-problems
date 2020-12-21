namespace BinaryTrees {

    public class BinaryTreeNode {
        // properties
        public int val;
        public BinaryTreeNode left, right;

        // constructor
        public BinaryTreeNode(int val = 0, 
            BinaryTreeNode left = null, BinaryTreeNode right = null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public BinaryTreeNode convertToTree(int[] arr) {
        if (arr.Length == 0) return null;
        return constructTreeFromArray(arr, 0, arr.Length-1); // here you are putting the indexes not the vlaues themselves!
        }

        private BinaryTreeNode constructTreeFromArray(int[] arr, int left, int right) {
        if (left > right) return null;
        int midpoint = left + (right-left) / 2;
        BinaryTreeNode node = new BinaryTreeNode(arr[midpoint]);
        System.Console.WriteLine(arr[midpoint]);
        node.left = constructTreeFromArray(arr, left, midpoint-1);   // here you are recursively assigning the left side
        node.right = constructTreeFromArray(arr, midpoint+1, right); // here you are recursively assigning the right side

        return node;
        }

    }

}