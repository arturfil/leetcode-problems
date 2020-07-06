using System;
using System.Text.RegularExpressions;

namespace algorithms {

  public class Defanging {
    public string change(string address) {
      // Solution One 
      string[] strings = address.Split(".");
      address = "";
      for(int i = 0; i < strings.Length; i++)  {
        address += strings[i];
        if (i == strings.Length - 1) break;
        address += "[.]";
      }

      /* Solution Two
      string[] str = address.Split(".");
      address = str[0] + "[.]" + str[1] + "[.]" + str[2];
      System.Console.WriteLine(address);
      */

      /* Solution Three
        address = adress.Replace(".", "[.]");
      */
      return address;
    }
  }

}