using System;
using System.Collections.Generic;
using System.Text;

namespace NoFactoryDemo
{
    public interface CreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
