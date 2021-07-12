using System;

namespace NoFactoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the card type you would like to visit: ");
            string cardType = Console.ReadLine();
            CreditCard cardDetails = null;
            
            if (cardType == "moneyback")
            {
                cardDetails = new MoneyBack();
            }
            else if (cardType == "titanium")
            {
                cardDetails = new Titanium();
            }
            else if (cardType == "platinum")
            {
                cardDetails = new Platinum();
            }

            if (cardDetails != null)
            {
                Console.WriteLine("CardType : " + cardDetails.GetCardType());
                Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
                Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.ReadLine();
        }
    }
}
