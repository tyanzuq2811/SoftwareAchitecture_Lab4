using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(string cardType)
        {
            if (cardType == "MoneyBack")
            {
                return new MoneyBack();
            }
            else if (cardType == "Titanium")
            {
                return new Titanium();
            }
            else if (cardType == "Platinum")
            {
                return new Platinum();
            }
            else
            {
                throw new ArgumentException("Invalid card type");
            }
    }
}
