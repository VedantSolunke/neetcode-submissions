public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        
        int buyPrice = prices[0];
        int sellPrice = prices[0];

        for(int i=0; i < prices.Length; i++){
            if(prices[i] < buyPrice) {
                buyPrice = prices[i]; 
                sellPrice = prices[i];
            }
            if(prices[i] > sellPrice) sellPrice = prices[i];
            maxProfit = Math.Max(maxProfit, sellPrice - buyPrice);
        }

        
        return maxProfit;
    }
}
