namespace _121_BestTimeToBuyAndSellStock;
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        var bestProfit = 0;
        
        var buyDay = 0;
        var sellDay = 0;

        while (sellDay < prices.Length)
        {
            if (prices[buyDay] > prices[sellDay])
            {
                buyDay = sellDay;
            }
            else
            {
                var profit = prices[sellDay] - prices[buyDay];
                if (profit > bestProfit)
                {
                    bestProfit = profit;
                }
            }

            sellDay++;
        }

        return bestProfit;
    }
}
