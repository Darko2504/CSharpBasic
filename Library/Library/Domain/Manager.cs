
namespace Library.Domain
{
    public class Manager : Employee
    {
        public Manager(string firstName, string lastName, double salary, string department)
          : base(firstName, lastName, salary, Role.Manager)
        {
            Department = department;
            Bonus = 0;
        }
        private double Bonus { get; set; }
        public string Department { get; set; }
        public void AddBonus(double amount)
        {
            Bonus += amount;
        }
        public override double GetSalary()
        {
            return Salary + Bonus;
        }
    }
}

