using System;
using System.Collections.Generic;
using System.Linq;

namespace algorithms {

  public class FizzBuzz {

    public IList<string> Print(int n) {
      IList<string> list = new List<string>();
      for(int i = 1; i<=n; i++) {
          if (i % 3 == 0 && i % 5 == 0 ) 
            list.Add("FizzBuzz");
          else if (i%5 == 0) 
            list.Add("Buzz");
          else if (i%3 == 0)
            list.Add("Fizz");
          else
            list.Add($"{i}");
      }
      String[] temp = list.ToArray();
      
      for (int j = 0; j < temp.Length; j++) {
        System.Console.WriteLine(temp[j]);
      }
      return list;
    }
    // This mehtod is faster due to the IEnumberable
    private IEnumerable<string> FizzBuzzing(int n) {
      int i = 1;
      while (i <= n) {
        if (i % 3 == 0 && i % 5 == 0) yield return "FizzBuzz";
        else if (i % 3 == 0) yield return "Fizz";
        else if (i % 5 == 0) yield return "Buzz";
        else yield return i.ToString();
        i++;
      }
    }
  }

}