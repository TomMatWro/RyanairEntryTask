namespace RyanairEntryTask
{
    public class EarningsCalculator : IEarningsCalculator
    {
        public Results Results { get; set; }
        public Employee Employee { get; set; }

        public EarningsCalculator(Employee employee)
        {
            Employee = employee;
        }

        public void CalculateGrossAmound()
        {
            Results.GrossAmount = Employee.HourlyRate * Employee.WorkedHours;
        }

        public void CalculateIncomeTax()
        {
            throw new System.NotImplementedException();
        }

        public void CalculateUniversalSocialCharge()
        {
            throw new System.NotImplementedException();
        }

        public void CalculateNetAmount()
        {
            throw new System.NotImplementedException();
        }
    }
}