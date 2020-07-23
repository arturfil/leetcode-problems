namespace algorithms {

  class BuySell {

    // examples [7,1,5,3,6,4]; max prof = 7; (5 - 1) + (6 - 3) = 7; 
    // [1,2,3,4,5] max prof = 5 - 1 = 4;
    /*
      this will have to save two lowest values
      and to max values;
      Let's start by findind end returning the two lowest values;
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

  }

}