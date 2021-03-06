using System;

namespace algorithms {

  public class Palindrome {

    public string largestPalindrome(string s) {
      if (string.IsNullOrEmpty(s)) return String.Empty;
      var res = string.Empty;
      var reslen = 0;

      for (int i = 0; i < s.Length; i++) {
        var p1 = expandAroundCenter(s, i, i);
        if (p1.Length > reslen) {
            reslen = p1.Length;
            res = p1;
        }

        var p2 = expandAroundCenter(s, i, i + 1);

        if (p2.Length > reslen) {
            reslen = p2.Length;
            res = p2;
        }
      }
      return res;
    }

    private string expandAroundCenter(string s, int i, int j) {
      while (i >= 0 && j < s.Length && s[i] == s[j]) {
          i--;
          j++;
      }

      return s.Substring(i + 1, j - i - 1);
    }

  }

}