using System;

namespace algorithms
{
    // Given the array nums, for each nums[i] find out how many numbers in the array are smaller than it. 
    // That is, for each nums[i] you have to count the number of valid j's 
    // such that j != i and nums[j] < nums[i].   
    
    public class Smaller_Current {
      // Example: {8,3,10,9};
      public int[] SmallerNumbersThanCurrent(int[] nums) {
        int[] new_arr = new int[nums.Length-1];
        int count = 0;
        for(int i = 0; i < nums.Length-1; i++) {
          for (int j = 1; j < nums.Length-1; j++)
          {
              if (i > j)
                count++;
          }
          new_arr[i] = count;
        }
        foreach (var index in new_arr) {
          Console.WriteLine(index);
        }
        return new_arr;
      }

    } 
}