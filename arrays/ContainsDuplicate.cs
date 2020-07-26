using System;
using System.Collections.Generic;

namespace algorithms {

  // Input needed in main class to run and test:
  /*
    ContgainsDuplicate dup = new ContgainsDuplicate();
    int[] test_case = {1,2,3,1};
    int[] test = {2,14,18,22,22};
    int[] pointer_arr = {3,1};
    int[] test_null = {};
    bool result = dup.hashtableMethod(test_null);
    System.Console.WriteLine(result);
  */

  public class ContgainsDuplicate {

    // [1,2,3,1] <- test array
    
    // - we cannot use a double for loop because it will use the same index at some point 
    //   and that is not what we want
    // - we wither want two pointer like in buysell proble or we want to do xor operation

    // NAIVE APROACH! THIS IS On^2
    public bool linearMethod(int[] nums) {
      if (nums == null || nums.Length == 0) return false;
      for (int i = 0; i < nums.Length; i++) {
        for(int j = 0; j < i; ++j) {
          if (nums[j] == nums[i]) return true;
        }
      }
      return false;
    }

    
    // You can also implement a sorting algorithm and then just check if there are two consecutive values that 
    // are duplicated, this is also not the most efficient since this is O(nlogn)
    // Though the space complexity is O(1) so depends on what they are asking you to optimize for. space vs run-time.
    public bool sortingMethod(int[] nums) {
      Array.Sort(nums);
      for (int i = 0; i < nums.Length-1; i++) {
        if (nums[i] == nums[i+1]) return true;
      }
      return false;
    }

    // Therefore the most run-time efficient method would be creating a Hashtable (dictionary on C#).
    public bool hashtableMethod(int[] nums) {
      HashSet<int> set = new HashSet<int>(nums.Length);       
      foreach(var item in nums) 
        if (!set.Add(item))
          return true;

      return false;
    }
  }

}