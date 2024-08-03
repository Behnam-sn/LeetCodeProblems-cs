namespace LeetCodeProblems;

// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/

public class BestTimeToBuyAndSellStock2
{
    class PossibleDeal
    {
        public int BuyAt;
        public int SellAt;
        public List<PossibleDeal> NextDeals = [];
    }

    // Not Working
    public static int Solution1(int[] prices)
    {
        if (prices.Length == 1)
        {
            return 0;
        }

        var maxProfit = 0;
        var possibleDeals = new List<PossibleDeal>();

        for (var i = 0; i < prices.Length; i++)
        {
            for (var j = 0; j < i; j++)
            {
                if (prices[j] < prices[i])
                {
                    // add indexes to possibleDeals
                    var pd = new PossibleDeal
                    {
                        BuyAt = j,
                        SellAt = i,
                    };
                    var idk = Deal(possibleDeals, pd);
                    if (idk == false)
                    {
                        possibleDeals.Add(pd);
                    }
                }
            }
        }

        for (var i = 0; i < possibleDeals.Count; i++)
        {
            var pd = possibleDeals[i];
            var aaa = 0;
            while (true)
            {
                aaa += pd.SellAt - pd.BuyAt;

            }
        }

        return maxProfit;
    }

    private static bool Deal(List<PossibleDeal> deals, PossibleDeal pd, bool deled = false)
    {
        foreach (var possibleDeal in deals)
        {
            if (possibleDeal.SellAt < pd.BuyAt)
            {
                if (possibleDeal.NextDeals.Count == 0)
                {
                    possibleDeal.NextDeals.Add(pd);
                    deled = true;
                }
                else
                {
                    deled = Deal(possibleDeal.NextDeals, pd, deled);
                }
            }
        }
        return deled;
    }

    public static int Solution2(int[] prices)
    {
        throw new NotImplementedException();
    }
}