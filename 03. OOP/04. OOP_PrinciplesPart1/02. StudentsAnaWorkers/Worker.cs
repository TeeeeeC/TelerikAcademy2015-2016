namespace _02.StudentsAnaWorkers
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public int WeekSalary { get; private set; }
        public int WorkHoursPerDay { get; private set; }

        public static int MoneyPerHour(int money)
        {
            return money * 8;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " -";
        }
    }
}
