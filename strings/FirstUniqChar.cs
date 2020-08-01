using System;

namespace algorithms {

  public class FirstUniqChar {
    /*
      Check withing a string if there is a a non-repeating char in a string and return
      the index where the char can be found at.

      The way you check that there are no-repeating characters is by making sure there
      are no duplicates.

      // sort the stings and then check if the next character doesn't match
      // dictionary? less expensive but more space complexity required
    */
    public int checkFirstChar(string s) {
      char[] s_arr = s.ToCharArray();
      
      for (int i = 0; i < s_arr.Length-1; i++) {
        if (!foundDuplicate(s, s[i])) return i;
      }
      return -1;
    }

    public Boolean foundDuplicate(string s, char c) {
      int counter = 0;
      for (int i = 0; i < s.Length; i++) {
        if (c == s[i]) counter++;
      }
      if (counter >= 2) return true;
      return false;
    }

  }

}