namespace Factory
{
    public class Platinum : ICreditCard
    {
        public string GetCardType()
        {
            return "Platinum";
        }
        public int GetCreditLimit()
        {
            return 100000;
        }
        public int GetAnnualCharge()
        {
            return 1000;
        }
    }
}