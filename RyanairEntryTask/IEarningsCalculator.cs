namespace RyanairEntryTask
{
    public interface IEarningsCalculator
    {
        void CalculateGrossAmound();
        void CalculateIncomeTax();
        void CalculateUniversalSocialCharge();
        void CalculateNetAmount();
    }
}