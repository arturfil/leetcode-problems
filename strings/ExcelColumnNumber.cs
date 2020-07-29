using System;
using System.Collections.Generic;

namespace algorithms {

  public class ExcelColumnNumber {
    /*
      Check which value they give us.
      Ceck which base they are giving us that on
      * Max length = 7;
      ZY = 701 -> This means that [YZ => (26^1) * letter_value] + [(26^0) * letter_value]
    */

    // Dictionary? Array?, depends on the space complexity and time complexity restrictions

    public int ColumnToNumber(string s) {

      // Y * (26^0) = 25
      // Z * (26 ^ power)
      // ZY <-
      int power = 0;
      int total = 0;
      for (int i = s.Length - 1; i >= 0; i--) {
        int current_letter = char.ToUpper(s[i]) - 64;
        total += current_letter * (int)Math.Pow(26, power);
        power++;
      }

      return total;
    }

  }

}