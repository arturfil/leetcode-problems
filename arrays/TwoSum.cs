namespace algorithms {

  /**
    This problem is asking you to return the index where the condition of the target sum is met,
    NOT the actaul values!
    if nums = [1,4,5,6,9]; target = 7;
    you should return an array with values => [0,4]; Because this indexes cointain values 1 + 6 which equals target
  */

  public class TwoSum {

    public int[] returnSum(int[] nums, int target) {
      int[] result = new int[2];
      for(int i = 0; i < nums.Length; i++) {
        for (int j = 0; j < nums.Length; j++) {
            if (j != i && nums[i] + nums[j] == target) {
              result[0] = j;
              result[1] = i;
              break;
            }
        }
      }
      System.Console.Write("[ ");
      foreach(var num in result) {
        System.Console.Write(num + " ");
      }
      System.Console.Write("]");

      return result;
    }

  }

}