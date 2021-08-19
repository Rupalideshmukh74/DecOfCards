using System;

namespace Dec_of_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Dec of cards!");
            Cards cards = new Cards();
            cards.CardsCreator();
        }
    }
}
