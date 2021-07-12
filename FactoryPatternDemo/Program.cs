using System;

namespace FactoryPatternDemo
{
    class Program
    {
        static void Main()
        {
            CardFactory factory = null;

            Console.Write("Enter the card type you would like to visit: ");
            string value = Console.ReadLine();

            factory = CardFactory.CreateCardFactory(value);
            CreditCard creditCard = factory.GetCreditCard();

            Console.WriteLine("\nYour card details are below : \n");
            Console.WriteLine("Card Type: {0}\nCredit Limit: {1}\nAnnual Charge: {2}",
                creditCard.CardType, creditCard.CreditLimit, creditCard.AnnualCharge);
            Console.ReadKey();
        }
    }
}
