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

            ValidAnagram vAnagram = new ValidAnagram();
            string s1 = "anagram";                           // NOTE: this go with doulbe quotes on implementation
            string s2 = "nagaram";                           // NOTE: this go with doulbe quotes on implementation
            System.Console.WriteLine(vAnagram.isAnagram(s1, s2));
        }
    }

}   