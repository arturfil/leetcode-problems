namespace algorithms {

  public class MaxSubArray {

  // Given an integer array nums, find the contiguous subarray 
  // (containing at least one number) which has the largest sum and return its sum.

  // Example:

  // Input: [-2,1,-3,4,-1,2,1,-5,4],
  // Output: 6
  // Explanation: [4,-1,2,1] has the largest sum = 6.
 

    public int largestSum(int[] nums) {
      int total = 0;
      int beg = 0;
      int end = 0;
      

      for (int i = beg; i < nums.Length - end; i++) {
        if (nums[beg] < 0) beg++;
        if ((nums[beg] + nums[beg+1]) < 0) beg += 2;
        if (nums[end] < 0) end++;
        if ((nums[end] + nums[end+1]) < 0) end += 2;
      }

      for (int i = beg; i < nums.Length-end; i++) total += nums[i];

      return total;
    }

  }

}