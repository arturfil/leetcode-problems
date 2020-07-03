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
            int[] nums = {4,4,1,2,3,1,2};
            SingleNumber single = new SingleNumber();
            single.single(nums);

        }
    }

}   