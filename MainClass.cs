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

						int[] nums1 = {4,9,5};
            int[] nums2 = {9,4,9,8,4};

            IntersectionII intersection = new IntersectionII();
            intersection.Intersect(nums1, nums2);

        }
    }

}   
