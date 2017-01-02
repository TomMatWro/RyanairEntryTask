using System.Dynamic;

namespace RyanairEntryTask
{
    public class GrossAmountCalculator
    {
        public double GrossAmount { get; set; }

        public GrossAmountCalculator()
        {
            GrossAmount = 0;
        }

        private void CalculateGrossAmount(Employee employee)
        {
            GrossAmount = employee.HourlyRate * employee.WorkedHours;
        }
    }
}