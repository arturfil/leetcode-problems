namespace algorithms
{
  /*
    Example 2:

    Input: "()[]{}"
    Output: true

    Example 3:

    Input: "(]"
    Output: false

    Example 4:

    Input: "([)]"
    Output: false
  */

    public class ValidParenthesis {
      public bool IsValid(string s) {
        string valid = "{}()[]";
        for(int i = 0; i < s.Length; i++) {
          for (int j = 0; j < valid.Length; j++) {
              if (s[i] == valid[j]) {
                System.Console.WriteLine($"The string found matches with the index {j} in the valid string");
              }
          }
        }
        return true;
      }
    }
}