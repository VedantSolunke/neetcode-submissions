class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        res = 0
        minValue = prices[0]

        for i in prices:
            minValue = min(minValue, i)
            profit = i - minValue
            res = max(res, profit)
            
        return res
        