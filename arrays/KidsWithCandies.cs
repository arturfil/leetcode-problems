using System.Collections.Generic;

namespace algorithms {
  
  public class KidsWithCandies {
    public IList<bool> measure(int[] candies, int extraCandies) {
      int max = getMax(candies);
      bool[] response = new bool[candies.Length];
      System.Console.WriteLine($"Max in this case is {max}");
      for(int i = 0; i < candies.Length; i++) {
        if (candies[i] + extraCandies >= max) {
          response[i] = true;
        } else {
          response[i] = false;
        }
        System.Console.WriteLine(response[i]);
      }
      return response;
    }

    public int getMax(int[] arr) {
      int max = 0;
      for (int i = 0; i < arr.Length; i++) {
        int compare = arr[i];
        if (compare > max) {
          max = compare;
        }
      }
      return max;
    }
  }

  /* 
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
      int max = candies.Max();
      List<bool> list = candies.Select(c => c + extraCandies >= max).ToList();

      //foreach (int candy in candies)
      //{
      //    list.Add(candy + extraCandies > candies.Max());
      //}

      return list;
    }
    */

}