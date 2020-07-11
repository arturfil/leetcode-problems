using System;
using System.Collections.Generic;

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
            int[] test_nums = {2,2,3,1,3,2,1,1,1};
            System.Console.WriteLine(major.returnMayorElement(test_nums));            
        }
    }

}   
