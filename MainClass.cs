using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using math;

namespace algorithms
{

    class MainClass {
        
        static void Main(string[] args) {
            // Check each class in case that you want to see solved and pending problems.
            // SolvedProblems solved = new SolvedProblems();
            // PendingProblems pending = new PendingProblems();
            // solved.print();
            // pending.print();

            int test = 3;
            ClimbingStairs stairs = new ClimbingStairs();
            int result = stairs.NumOfWays(test);

            System.Console.WriteLine(result);
           
				}
    }

}   


