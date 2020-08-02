using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace algorithms {

  // TESTING
  /*
    FirstUniqChar first = new FirstUniqChar();
    string test = "abcabd"; // this should return 2 since "c" is the first non
    // repeating character
    int solution = first.returnFirstUniqChar(test);
    System.Console.WriteLine(solution);
    // Boolean result = first.foundDuplicate(test, 'c');
    // System.Console.WriteLine(result);
  */

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
      if (s.Length == 1) return 0;
      
      for (int i = 0; i < s.Length; i++) {
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

    // Previous method works but that is a brute force algorithm,
    // more efficiently would be a HashMap algorithm
    public int returnFirstUniqChar(string s) {
      // build hash map : char and how often it appears
      var dict = new Dictionary<char, int>();
      for (int i = 0; i < s.Length; i++) {
        if (!dict.ContainsKey(s[i]))
          dict[s[i]] = 0;
        else
          dict[s[i]] = dict[s[i]]+1;
      }

      for (int i = 0; i < s.Length; i++) 
        if(dict[s[i]] == 0) return i;

      return -1;
    }
  }


}