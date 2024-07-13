namespace LeetCodeProblems;

// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/

public class BestTimeToBuyAndSellStock
{
    public static int Solution1(int[] prices)
    {
        var maxProfit = 0;

        if (prices == null || prices.Length < 2)
        {
            return maxProfit;
        }

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
}