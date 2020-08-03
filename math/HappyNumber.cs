using System;

namespace algorithms {

  public class HappyNumber {

    public bool isHappy(int n) {
      System.Console.WriteLine(Math.Pow(n,2));
      if (Math.Pow(n, 2) == 1) return true;

      return false;
    }

  }

}