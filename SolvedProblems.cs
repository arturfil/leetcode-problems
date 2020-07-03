namespace algorithms
{

  public class SolvedProblems {
    
    public void print() {
      System.Console.WriteLine(
        @"
          This Problems are solved:
          ------------------------

          /**
          KidsWithCandies kidncandie = new KidsWithCandies();
          int[] candies = {1,3,9};
          int extra = 4;
          kidncandie.measure(candies, extra);
          
          /**
          RunningSum runningSum = new RunningSum();
          int[] ex_nums = {1,2,3,4};
          running sum problem;
          runningSum.Add(ex_nums);

          /**
          Defanging def = new Defanging();
          string ip_address = '123.123.422.92' // these go in double quotations when testing
          def.change(ip_address);

          /**
          char[] test = {'h','e','l','l','o'};
          ReverseString revStr = new ReverseString();
          revStr.reverse(test);

          /**
          Divisor Game
        "
      );
    }

  }
    
}