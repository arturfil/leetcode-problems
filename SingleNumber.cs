namespace algorithms {

/**
Given a non-empty array of integers, every element appears twice except for one. Find that single one.

Note:
Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?

Example 1:
Input: [2,2,1]
Output: 1

Example 2:
Input: [4,1,2,1,2]
Output: 4
*/

  // This problem is EXTREMELY ticky
  /**
    I started by using a foorloop and that didn't work.
    I start using recursion and also that didn't work.
    I saw one solution but the space was expanded by initializing a hash map.
    - The thinking behind implementing a HashMap is that you store keys and values on the hashmap which has O(1)
    - if you find two of the same keys, you update the value to 2 -> you have found 2 values of that key
    - After you iterate once through all the array, you simpley return the key with value of 1 (or a frequency of 1)
    - Since this method uses a lot of memory, the problem requirements aren't met
    
    Solution explanation:
     - '^' is the XOR bitwise operator. This means that when you do a '^=' you are assigning the value to another 
     as long as their are not the same.
     - The thinking behind this is that you will start with the first value of the array
     - You assing result to zero that way you asing result to the next array value when you use the equals and XOR
     - The main idea here is thay you should have a pair of numbers except for one AND XOR works in the following way.
     every same number comparison e.g. 5^5 = 0; 4^4 = 0; 3^3 = 0 ...
     therefore at some point either you will end up with a 0 and assing the single value with 0 ^ single vaue => single value;
     OR a combination of XOR made the single value, when evaluated with another value become 0.
     That combination that made the single value 0, will repeat again but inversly which will return the single value later on.
     This is because the other value are REPEATED, and hence we will end up only with the single value as a result one way or another.
  */
  public class SingleNumber {
    // test array = {4, 1, 2, 4, 5, 1, 2};
    /* result print out:
        4
        0
        1
        3
        2
        0
        5
    */
    public int single(int[] nums) {
      int result = 0;
      System.Console.WriteLine("\nasg arr res");
      System.Console.WriteLine("------------");
      for(int i = 0; i<nums.Length; i++) {
        System.Console.WriteLine($" {result} ^ {nums[i]} = {result ^ nums[i]}");
        result ^= nums[i];
      }
      System.Console.WriteLine($"The single number is {result}\n"); 
      return result;
    }


  }

}