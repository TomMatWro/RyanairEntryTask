namespace RyanairEntryTask
{
    public class Employee
    {
        public int WorkedHours { get; set; }
        public double HourlyRate { get; set; }
        public Location Location { get; set; }

        public Employee(int workedHours, int hourlyRate, Location location)
        {
            WorkedHours = workedHours;
            HourlyRate = hourlyRate;
            Location = location;
        }


    }
}