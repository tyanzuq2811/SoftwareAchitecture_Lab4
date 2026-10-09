namespace Factory
{
    public class MoneyBack : ICreditCard
    {
        public string GetCardType()
        {
            return "MoneyBack";
        }
        public int GetCreditLimit()
        {
            return 20000;
        }
        public int GetAnnualCharge()
        {
            return 100;
        }
    }
}