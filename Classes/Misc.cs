using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace YugiohPriceMonitoring.Classes
{
    class Misc
    {
        /// <summary>
        /// Adds up total market value of collection
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static string getTotalPriceMarket(List<Card> collection)
        {
            double total = 0;

            foreach(Card card in collection)
            {
                
                if (card.getMarketPrice().Equals(string.Empty))
                {
                    continue;
                }

                total += Double.Parse(card.getMarketPrice());
            }

            return total.ToString();
        }

        /// <summary>
        /// Adds up total lowest value of a collection
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static string getTotalPriceLowest(List<Card> collection)
        {
            double total = 0;

            foreach (Card card in collection)
            {
                Console.WriteLine(card.getLowestPrice());
                if (card.getLowestPrice().Equals(string.Empty))
                {
                    continue;
                }

                total += Double.Parse(card.getLowestPrice());
            }

            return total.ToString();
        }
    }
}
