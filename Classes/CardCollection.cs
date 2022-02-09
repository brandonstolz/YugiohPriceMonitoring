using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YugiohPriceMonitoring.Classes
{
    class CardCollection
    {
        private List<Card> cardList;

        public CardCollection(List<Card> cardList)
        {
            this.cardList = cardList;
        }

        public Card getCard(int index)
        {
            return cardList[index];
        }
    }
}
