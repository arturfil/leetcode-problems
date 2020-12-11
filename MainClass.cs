

using Greedy;

namespace algorithms
{

    class MainClass {
        
        static void Main(string[] args) {
            // Check each class in case that you want to see solved and pending problems.
            // SolvedProblems solved = new SolvedProblems();
            // PendingProblems pending = new PendingProblems();
            // solved.print();
            // pending.print();


          //  int[] test = {1,3,5,6};
          //  var subArray = new MaxSubArray(); 
          //  var ans = subArray.largestSum(test);
          //  System.Console.WriteLine(ans);

          // int[] test = {1,1,2,3,4};
          // var duplicates = new RemoveDuplicates();
          // duplicates.remove(test);

          int[] test = {-2,1,-3,4,-1,2,1,-5,4};
          var max = new MaxSubArray();
          max.largestArray(test);

        }   
    }

}   


/*
  | 1 + 1 + 1 + 1
    2 + 2
    1 + 1 + 2
    1 + 2 + 1
    2 + 1 + 1
*/