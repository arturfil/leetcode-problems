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
            ValidAnagram val = new ValidAnagram();
            string test1 = "param";
            string test2 = "parma";
            val.isAnagram(test1, test2);

        }
    }

}   