namespace algorithms {

  /**
    Example 1:

    Input: nums = [1,2,3,4]
    Output: [1,3,6,10]
    Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].
  */

  public class RunningSum {
    public int[] Add(int[] nums) {
      for (int i = 1; i < nums.Length; i++) 
      {
        nums[i] = nums[i] + nums[i-1];
      }
      return nums;
    }
  }
}