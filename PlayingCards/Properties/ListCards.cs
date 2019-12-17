using System;
using System.Collections.Generic;

namespace PlayingCards.Properties
{
    public class ListCards
    {
        public static List<Cards> listCard()
        {
            var card = new List<Cards>();
            for (int i =0 ; i <= 12; i++)
            {
                for(int j = 1; j <= 4; j++)
                {
                    card.Add(new Cards { num = i, type = j });
                }
            }
            return card;
        }
    }
}
