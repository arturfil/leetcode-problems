using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace algorithms
{

    class MainClass {
        
        static void Main(string[] args) {
            // Check each class in case that you want to see solved and 
            // pending problems.
            // SolvedProblems solved = new SolvedProblems();
            // PendingProblems pending = new PendingProblems();
            // solved.print();
            // pending.print();

            // Testing Area
            // ------------   
            MajorityElement major = new MajorityElement();
            int[] test_nums = {4,4,4,2,3};
            int result = major.returnMajElementDict(test_nums);
            System.Console.WriteLine(result);

        }
    }

}   