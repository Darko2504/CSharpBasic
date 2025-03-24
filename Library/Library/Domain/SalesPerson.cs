
namespace Library.Domain
{
   public class SalesPerson : Employee
    {
        public SalesPerson(string firstName, string lastName, double salary, Role role, double success) 
            : base(firstName, lastName, 500, Role.Sales)
        {
            SuccessSaleRevenue = success;
        }
        private double SuccessSaleRevenue { get; set; }
        public void AddSuccessRevenue(double amount)
        {
            SuccessSaleRevenue = amount;
        }
        public override double GetSalary()
        {
            double bonus = 0;

            if (SuccessSaleRevenue <= 2000)
            {
                bonus = 500;
            }
            else if (SuccessSaleRevenue <= 5000)
            {
                bonus = 1000;
            }
            else if(SuccessSaleRevenue < 5000)
            {
                bonus = 1500;
            }

            return Salary + bonus;
        }
    }
}

