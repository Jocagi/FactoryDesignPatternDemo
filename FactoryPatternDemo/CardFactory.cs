using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternDemo
{
    /// <summary>  
    /// The 'Creator' Abstract Class  
    /// </summary>  
    abstract class CardFactory
    {
        public abstract CreditCard GetCreditCard();

        public static CardFactory CreateCardFactory(string factoryType)
        {
            CardFactory factory = null;

            switch (factoryType.ToLower())
            {
                case "moneyback":
                    factory = new MoneyBackFactory(50000, 0);
                    break;
                case "titanium":
                    factory = new TitaniumFactory(100000, 500);
                    break;
                case "platinum":
                    factory = new PlatinumFactory(500000, 1000);
                    break;
                default:
                    break;
            }

            return factory;
        }
    }
}
