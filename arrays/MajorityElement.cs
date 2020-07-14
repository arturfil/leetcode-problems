using System.Collections.Generic;

namespace algorithms {

  public class MajorityElement {
    // {1,2,2,2,3,1,1,3,4,2,1,1,1};

    /*
      Iterative Method
      Why use an iterative method? seems innefficient and uses On^2 time complexity?
      The reason to choose for an iterative method is that the space complexity is constant.
      This means that the memory used is the array.
      This would benefit somebody that memory is a scarse resource but not time.
      Probably a startup where the users aren't a large number but the server cost is really high.
    */
    public int returnMayorElement(int[] nums) {
      
      int max_counter = nums.Length / 2;

      foreach(int num in nums) {
        int count = 0;
        foreach(int element in nums) {
          if (element == num) {
            count++;
          }
        }

        if (count > max_counter) {
          System.Console.WriteLine(num);
          return num;
        }
      }
      return -1;
    }

    /*
      For this method we are going to use a HashMap
      HashMap has a time complexity of O(n) but it also has a
      Space complexity of O(n). Large companies where they have the 
      resources to allocate a lot of memory space, they would opt
      for a more expensive space process but in return they gain 
      Efficiency.
    */
    // private Map<integer, integer> count_numbers(int[] nums) {
    //   Map<Integer, Integer> counts = new HashMap<Integer, Integer>();
    //   foreach (int num in nums) {

    //   }
    // }

    public int returnMajElementDict(int[] nums) {
      // Dictionary Mehtod.
      Dictionary<int, int> dict = new Dictionary<int, int>();
      if (nums.Length == 1)
        return nums[0];


      int majority = nums.Length/2;
      foreach(int val in nums) {
        if (dict.ContainsKey(val)) {
          dict[val]++;
          if (dict[val] > majority) {
            return val;
          }

        } else {
          dict[val] = 1;
        }
      }
      return -1;
    }

    public int returnMajElementVoting(int[] nums) {
        // Boyer-Moore majority vote algorithm
      // I have to check how this algorithm works
      int result = 0;
      int count = 0;
      foreach(int n in nums) {
        if (count == 0) {
          result = n;
          count = 1;

        } else if (n == result) {
          count++;
        } else {
          count--;
        }
      }
      return result;
    }

  }

}