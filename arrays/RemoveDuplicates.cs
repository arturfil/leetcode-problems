using System;

namespace algorithms.arrays {

  public class RemoveDuplicates {

    public int remove(int[] nums) {
      if (nums.Length == 0) return 0; // because the array would be empty;
      int j = 0;

      // you want to start the loop at 1 that way you can compare different numbers
      for (int i = 1; i < nums.Length; i++) {
        if (nums[j] != nums[i]) {
          j++;
          nums[i] = nums[j];
        }
      }
      System.Console.WriteLine(j+1);
      return j + 1;
    }

  }

}