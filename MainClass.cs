using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace algorithms
{

    class MainClass {
        
        static void Main(string[] args) {
            // Check each class in case that you want to see solved and pending problems.
            // SolvedProblems solved = new SolvedProblems();
            // PendingProblems pending = new PendingProblems();
            // solved.print();
            // pending.print();

            var happy = new HappyNumber();
            int num = 19;
            

            var result = happy.IsHappy(num);
            System.Console.WriteLine(result);
				}
    }

}   
