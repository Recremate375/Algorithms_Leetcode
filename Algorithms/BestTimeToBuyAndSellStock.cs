using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

namespace Algorithms
{
    public class BestTimeToBuyAndSellStock
    {

        public int MaxProfit(int[] prices) 
        {
            //int maxProfit = 0; // O(N^2)
            //int element = 0;
            //int temporaryProfit = 0;

            //for (int i = 0; i < prices.Length; i++)
            //{
            //    element = prices[i];

            //    for (int j = i; j < prices.Length; j++)
            //    {
            //        if (element >= prices[j])
            //        {
            //            temporaryProfit = 0;
            //        }
            //        else if(temporaryProfit < prices[j] - element)
            //        {
            //            temporaryProfit = prices[j] - element;
            //        }
            //    }

            //    if (maxProfit < temporaryProfit)
            //    {
            //        maxProfit = temporaryProfit;
            //    }
            //}

            //return maxProfit;

            //O(N)
            int maxProfit = 0;
            int minPrice = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                minPrice = Math.Min(minPrice, prices[i]);
                maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
            }

            return maxProfit;
        }

    }

}

