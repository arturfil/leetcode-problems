namespace algorithms
{
  public class PendingProblems {

    public void print() {
      System.Console.WriteLine(
        @"
          This problems are pending: 
          --------------------------

          /**   
          ShuffleTheArray shuffle = new ShuffleTheArray();
          int[] arr_sh = {2,5,1,3,4,7};
          int n = 3;
          shuffle.Shuffle(arr_sh, n);

          /**
          ValidParenthesis valid = new ValidParenthesis();
          valid.IsValid('()[]{}'); // this go with double quotes
        "
      );
    }
  }
    
}