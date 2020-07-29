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
            ExcelColumnNumber excel_sol = new ExcelColumnNumber();
            string test_2 = "AA";
            int result = excel_sol.ColumnToNumber(test_2);
            System.Console.WriteLine(result);

        }
    }

}   