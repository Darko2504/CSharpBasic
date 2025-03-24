

namespace Library.Domain
{
    public class Contractor : Employee
    {
        public Contractor(string firstName, string lastName, double workHours, int payPerHour, Manager responsible)
            : base(firstName, lastName, 0, Role.Other)
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = responsible;
        }
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary;
        }

        public string CurrentPosition()
        {
            return Responsible.Department;
        }
    }
}
