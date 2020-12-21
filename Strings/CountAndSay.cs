
using System.Text;

namespace Strings {

  public class CountAndSay {
    /* 
      n = 3

      1. "1"
      2. "11"
      3. "21"
      4. "1211"
      5. "111221"
      6. "312211"
    */

    public string Say(int n) {
      if (n == 1) return "1";
      var pre = Say(n - 1);
      return SayNext(pre);
    }

    private static string SayNext(string start) {
      var res = new StringBuilder();
      var pre = 0;
      for (int i = 0; i < start.Length; i++) {
        if (start[i] != start[pre]) {
          res.Append(i - pre).Append(start[pre]);
          pre = i;
        }
      }

      res.Append(start.Length - pre).Append(start[pre]);
      return res.ToString();
    }

  }

}