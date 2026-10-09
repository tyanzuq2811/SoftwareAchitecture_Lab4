namespace Factory
{
    public class Titanium : ICreditCard
    {
        public string GetCardType()
        {
            return "Titanium";
        }
        public int GetCreditLimit()
        {
            return 50000;
        }
        public int GetAnnualCharge()
        {
            return 500;
        }
    }
}