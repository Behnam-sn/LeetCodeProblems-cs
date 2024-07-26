
namespace LeetCodeProblems;

public class BestTimeToBuyAndSellStock2
{
    public static int Solution1(int[] prices)
    {
        if (prices.Length == 1)
        {
            return 0;
        }

        var maxProfit = 0;
        for (var i = 0; i < prices.Length; i++)
        {
            for (var j = 0; j < i; j++)
            {
                if (prices[j] < prices[i])
                {
                    // add indexes to possibleDeals
                }
            }
        }
        // find maxProfit in possibleDeals 
        return maxProfit;
    }
}