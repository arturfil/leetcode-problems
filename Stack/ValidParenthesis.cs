using System.Collections.Generic;

namespace Stack
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

  // Think of recursion and possibly using a stack

    public class ValidParenthesis {
      private Dictionary<char, char> brackets = new Dictionary<char, char>() {
        {'(', ')'},
        {'[', ']'},
        {'{', '}'}
      };

      public bool IsValid(string s) {
        Stack<char> endings = new Stack<char>();

        foreach (var current in s) {
          if (brackets.ContainsKey(current)) {
            endings.Push(brackets[current]);
          } else if (endings.Count == 0 || endings.Pop() != current) {
            return false;
          }
        }

        return endings.Count == 0;
      }
    }
}