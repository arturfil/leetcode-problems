using System;

namespace algorithms
{
    class MainClass {
        
        static void Main(string[] args) {
            // Check each class in case that you want to see solved and 
            // pending problems.
            SolvedProblems solved = new SolvedProblems();
            PendingProblems pending = new PendingProblems();
            // solved.print();
            // pending.print();

            // Testing Area
            // ------------
            BinaryTree bt = new BinaryTree();
            bt.root = new Node(1);
            bt.root.left = new Node(2);
            bt.root.right = new Node(3);
            bt.root.left.left = new Node(4);
            bt.root.left.right = new Node(5);   
            int result = bt.maxDepth(bt.root);
            System.Console.WriteLine($"The height of the tree is {result}");

        }
    }

}   