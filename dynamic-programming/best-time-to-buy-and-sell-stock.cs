public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = 2147483647,maxProfit = 0;
        for (int i = 0; i < prices.Length; i++) {
            if (prices[i] < minPrice) {
                minPrice = prices[i];
            }
            else if (maxProfit < prices[i] - minPrice) {
                maxProfit = prices[i] - minPrice;
            }
        }
        return maxProfit;
    }
}