using System;
using System.Collections;
using System.Collections.Generic;

namespace algorithms {

  public class HappyNumber {
    
    /*
    ::::::::::::::::TESTING::::::::::::::::::::
    var happy = new HappyNumber();
    int num = 19;            
    var result = happy.IsHappy(num);
    System.Console.WriteLine(result);
    :::::::::::::::::::::::::::::::::::::::::::
      A "Happy number is only happy if the number itself returns 1 one it reduces all it's
      - digits to 1 by squaring each digit
      EX
      -19
      -1^2 + 9^2 = 82
      -8^2 + 2^2 = 68
      -6^2 + 8^2 = 100
      -1^2 + 0^2 + 0^2 = 1
    
      This is possible using a hashSet(Just value), we don't need a hastable(key, value);
      And vasically you want to divide by ten and also check num % 10, to get the single digit
      once you have that you want to square it (mulitply it by itself), 
      once you have that, you add that to your hashSet. 

      You will run this as long as n is not equal to 1 and is not inside the hashSet.
      Baically if you "repeat" the value or get stuck in a loop, you know it's not a happy number.
    */

    public bool IsHappy(int n) {      
      HashSet<int> seen = new HashSet<int>();
      while (n != 1 && !seen.Contains(n)) {
        seen.Add(n);
        n = getNext(n);
      }

      return n == 1;
    }

    public int getNext(int n) {
      int totalSum = 0;
      while (n > 0) {
        int d = n % 10;
        n /= 10;
        totalSum += d * d;
      }
      return totalSum;
    }
  }

}