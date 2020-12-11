using System;

namespace Greedy {

  public class MaxSubArray {

    // Given an integer array nums, find the contiguous subarray 
    // (containing at least one number) which has the largest sum and return its sum.

    // Example:

    // Input: [-2,1,-3,4,-1,2,1,-5,4],
    // Output: 6
    // Explanation: [4,-1,2,1] has the largest sum = 6.
    public int largestArray(int[] arr) { 
      int n = arr.Length;
      int current = arr[0];
      int tot = arr[0];

      for (int i = 1; i < n; i++) {
        current = Math.Max(arr[i], current + arr[i]);
        tot = Math.Max(tot, current);
      }

      System.Console.WriteLine(tot);
      return tot;
    }

  }

}