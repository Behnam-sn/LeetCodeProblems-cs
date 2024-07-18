namespace LeetCodeProblems;

// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/

public class BestTimeToBuyAndSellStock
{
    public static int Solution1(int[] prices)
    {

        if (prices == null || prices.Length < 2)
        {
            return 0;
        }

        var maxProfit = 0;
        for (var i = 0; i < prices.Length; i++)
        {
            var item1 = prices[i];
            for (var j = i + 1; j < prices.Length; j++)
            {
                var item2 = prices[j];

                if (item1 < item2)
                {
                    var temp = item2 - item1;
                    if (temp > maxProfit)
                    {
                        maxProfit = temp;
                    }
                }
            }
        }
        return maxProfit;
    }

    public static int Solution2(int[] prices)
    {
        if (prices == null || prices.Length < 2)
        {
            return 0;
        }

        var maxProfit = 0;
        var lowestPrice = prices[0];
        var highestPrice = prices[0];

        for (var i = 1; i < prices.Length; i++)
        {
            var price = prices[i];

            if (price < lowestPrice)
            {
                lowestPrice = price;
                highestPrice = price;
            }

            else if (price > highestPrice)
            {
                highestPrice = price;
                maxProfit = Math.Max(highestPrice - lowestPrice, maxProfit);
            }
        }

        return maxProfit;
    }
}
