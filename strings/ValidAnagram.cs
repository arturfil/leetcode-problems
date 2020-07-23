using System;

namespace algorithms {

  /**
    Given two strings s and t , write a function to determine if t is an anagram of s.

    Example 1:
    Input: s = "anagram", t = "nagaram"
    Output: true

    Example 2:
    Input: s = "rat", t = "car"
    Output: false

    Note:
    You may assume the string contains only lowercase alphabets.

    Follow up:
    What if the inputs contain unicode characters? How would you adapt your solution to such case?

    ----------------------------------------------------------------------------------------------
    // to check that this two are an anagram, first you sort them then you 
    // check whether the strings are equal if so, then they are an anagram.

  */

  public class ValidAnagram {

    // public bool Check(string s, string t) {
    //   if (s.Length != t.Length) 
    //     return false;

    //   char[] sOne = s.ToCharArray(); 
    //   char[] sTwo = t.ToCharArray(); 
      
    //   // sort method
    //   sOne = sort(sOne);
    //   sTwo = sort(sTwo);

    //   System.Console.WriteLine(sOne);
    //   System.Console.WriteLine(sTwo);
    //   s = new string(sOne);
    //   t = new string(sTwo);
    //   // System.Console.WriteLine($"Here we have s: {s} and t: {t}");
    //   return s == t;
    // }

    // public char[] sort(char[] arr) {
    //   int n = arr.Length; 
    //     for (int i = 1; i < n; ++i) { 
    //       char temp = arr[i]; 
    //       int j = i - 1; 

    //       // Move elements of arr[0..i-1], 
    //       // that are greater than temp, 
    //       // to one position ahead of 
    //       // their current position 
    //       while (j >= 0 && arr[j] > temp) { 
    //           arr[j + 1] = arr[j]; 
    //           j = j - 1; 
    //       } 
    //       arr[j + 1] = temp; 
    //     }
    //   return arr;
    // }

    public Boolean isAnagram(String s, String t) {
      if (s.Length != t.Length) return false;

      int[] counter = new int[26]; // you do a 26 space because the alphabet is made out of 26 
      for(int i = 0; i<s.Length; i++) {
        counter[s[i]-'a']++; // here you are doing, the character - a; will give you the position in the alphabet and so add 1
        counter[t[i]-'a']--; // here if it matches the line above, you substract, the idea is that the final sum == 0;
      }

      // first word = param; 1st interation 'p' - 'a' = 0;
      // scond = parma;
      // for (int i = 0; i < s.Length; i++) {
      //   System.Console.WriteLine(counter[i]);
      //   System.Console.WriteLine(s[i]-'a');
      //   System.Console.WriteLine(t[i]-'a');
      // }
      
      int number = 0;
      foreach (var letter in counter) {
        System.Console.WriteLine(letter);
        number ++;
      }

      System.Console.WriteLine($" the counter arr has {number} of items");


      foreach (var count in counter)
        if (count != 0) return false; // this condition happens if we don't have equal characters in the two strings!

      return true;
    }

  }


}