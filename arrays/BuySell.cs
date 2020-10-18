namespace algorithms {

  class BuySell {

    // examples [7,1,5,3,6,4]; max prof = 7; (5 - 1) + (6 - 3) = 7; 
    // [1,2,3,4,5] max prof = 5 - 1 = 4;
    /*
      In order to solve this algorithm you have to make the most amount of transactions (buys/sells)
      and that the difference between each transactions are the greatest. 
      We have as a constraint that we can do as many buy/sells as we can,
      but we cannot buy again until we sell the recently bought Stock.

      Logically we first pick the highest index value in the array and the next lowest index value
      after. We compare assign it to max and check for other possibilities

      After that we keep checking for other possible profits and add it to profit (having in mind the constraints)
      Lastly, we return the tot profit
    */
    public int MaxProfit(int[] prices) {
      if (prices == null || prices.Length == 0) return 0;

      int profit = 0;
      for(int i = 0; i < prices.Length-1; i++) {
        if (prices[i+1] > prices[i]) {
          profit += prices[i+1] - prices[i];
        }
      }
      System.Console.WriteLine($" The max profit is -> {profit}");
      return profit;
    }
    
    //{7,1,5,3,6,4};
    //{2,3,4,1};
    //{1,2}

    /**
      Here you want to choose the smallest value first after that fact you select the 
      largest value, that renders in the highest profit, simple.

      The coding constraints are that first you have to iterate throught the hole loop to 
      check which value is the smallest, once you traverse throught the whole loop you know that 
      the max value should be at the right of the minimum value. 

      Not having to traverse through all the array, could trim it.
    */


    /* For Testing

      int[] test = {7,1,5,3,6,4}; // should return {buy at 1 sell at 6 => 5}
      int[] test2 = {2,4,1}; // should return 2 {buy 2 sell at 4}
      int[] test3 = {1,2}; // should return 1 {buy at 1 sell at 2}
      BuySell buy = new BuySell();
      int result = buy.SingleMaxBuySell(test2);
      System.Console.WriteLine(result);

    */

    // [7,1,5,3,6,4]
    public int SingleMaxBuySell(int[] prices) {
      // return the max profit of one buy and one sell
      if (prices.Length == 0 || prices == null) return 0;
        
        int min = prices[0];
        int max = 0;
     
        for (int i = 0; i < prices.Length; i++) {
            if (prices[i] < min)
                min = prices[i];
            else if (prices[i] - min > max)
                max = prices[i] - min;
        }
        
        return max;
    }

  }


}