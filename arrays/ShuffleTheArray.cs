namespace algorithms {
  /*
    Input: nums = [2,5,1,3,4,7], n = 3
    Output: [2,3,5,4,1,7] 
    Explanation: Since x1=2, x2=5, x3=1, y1=3, y2=4, y3=7 then the answer is [2,3,5,4,1,7].
  */
  public class ShuffleTheArray {
    // TODO: rethink problem.
    public int[] Shuffle(int[] nums, int n) {
      int[] arr_a = new int[n];
      int[] arr_b = new int[n];
      for(int i = 0; i < nums.Length/2; i++) {
          arr_a[i%2] = nums[i];
      }
      return nums;
    }

  }

}