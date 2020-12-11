namespace math {
    
    class ClimbingStairs {

        /* :::::::: TESTING :::::::::::::::::::: //
            int test = 3;
            ClimbingStairs stairs = new ClimbingStairs();
            int result = stairs.NumOfWays(test);

            System.Console.WriteLine(result);
        // :::::::: TESTING ::::::::::::::::::::*/

        /*
        - This solution is using dynamic programming
        where it looks for previous solutions and then returns the result if such
        solution was found, that way  there is no need to add a computing cost
        - The brute force algorithm would be a 2^n tipe of solution since you can have n stairs 
        that could be either 1 or 2 therefore you can have 2^n combinations (where the comb sum doesn't
        exceed the allowed number of staris)

        And so, we can use dynamic programming to compute the number of combinations previously calculated 
        by storing the recursion solutions in an array.
        that way the time and space complexity become O(n) and O(n) repectively
        */

        public int NumberOfWays(int n) {
            int[] solutions = new int[n + 1];
            return NumberOfComb(0, n, solutions);
        }

        public int NumberOfComb(int i, int n, int[] sol) {
            if (i > n) return 0;

            if (i == n) return 1;

            if (sol[i] > 0) return sol[i];

            sol[i] = NumberOfComb(i + 1, n, sol) + NumberOfComb(i + 2, n, sol);
            return sol[i];
        }
    }

}