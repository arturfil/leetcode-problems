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

            // Testing Area
            // ------------   
            FirstUniqChar first = new FirstUniqChar();
            string test = "abcabd"; // this should return 2 since "c" is the first non
            // repeating character
            int solution = first.returnFirstUniqChar(test);
            System.Console.WriteLine(solution);
            // Boolean result = first.foundDuplicate(test, 'c');
            // System.Console.WriteLine(result);

        }
    }

}   