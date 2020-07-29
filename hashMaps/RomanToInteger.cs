using System.Collections.Generic;

namespace algorithms {

  // Implementation in MainClass.cs
  /*
    RomanToInteger solution = new RomanToInteger();
    string input = "CCCXLVI";
    int result = solution.convertRomanToInt(input);
    System.Console.WriteLine(result);
  */


  public class RomanToInteger {
    // "C C C X L V I"; // 346
    
    public int convertRomanToInt(string s) {

      Dictionary<char, int> roman_numbers = new Dictionary<char, int>() {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000},
      };

      int sum = 0;
      int previous = 0;

      for (int i = s.Length-1; i >= 0; i--) {
        int current = roman_numbers[s[i]];
        sum += previous > current ? -current : current;
        previous = current;
      }
      return sum;
    }
  }

}