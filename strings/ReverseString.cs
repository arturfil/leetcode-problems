namespace algorithms {

  public class ReverseString {

    public void reverse(char[] s) {
      // ["h","e","l","l","o"] -> ["o","e","l","l","h"]
      // char temp;
      // for(int i = 0; i < s.Length/2; i++) {
      
      //   temp = s[i];
      //   s[i] = s[s.Length - 1 - i];
      //   s[s.Length - 1 - i] = temp;
      // }
      // foreach(var ind in s) {
      //   System.Console.WriteLine(ind);
      // }

      // int len = s.Length - 1;
      
      // for (int l = 0, r = len; l < r; l++, r--)
      // {
      //     var tmp = s[l];
      //     s[l] = s[r];
      //     s[r] = tmp;
      // }      
    
      Reverse(s, 0, s.Length-1);
      // foreach(var ind in s) {
      //   System.Console.WriteLine(ind);
      // }
    }
    
    public void Reverse(char[] s, int left, int right) {
        char temp = s[left];
        if (left > right) 
            return;
        s[left] = s[right];
        s[right] = s[right];
        Reverse(s, left+1, right-1);
    }


  }

}