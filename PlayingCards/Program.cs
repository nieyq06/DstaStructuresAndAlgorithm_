using System;
using PlayingCards.Properties;

namespace PlayingCards
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var list = ListCards.listCard();

            foreach(var item in list)
            {
                int cd = item.num * 4 + item.type;
                Console.WriteLine(cd);
            }
        }


    }
}
