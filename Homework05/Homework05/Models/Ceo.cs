

namespace Homework05.Models
{
   public class Ceo : Employee
    {
        public Ceo(string firstName, string lastName, double salary, int shares, string company)
           : base(firstName, lastName, salary)
        {
            Employees = new Employee[0];
            Shares = shares;
            Company = company;
        }
        private double sharesPrice;
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        public string Company { get; set; }

        public void AddSharesPrice(double SharesPrice)
        {
            sharesPrice = SharesPrice;
        }

        public override double GetSalary()
        {
            return Salary + Shares * sharesPrice;
        }

        public void PrintEmployees()
        {
            Console.WriteLine("Employees:");
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
        }
       
        public void AddEmployee(Employee employee)
        {
            Employee[] tempArray = new Employee[Employees.Length + 1];
            for (int i = 0; i < Employees.Length; i++)
            {
                tempArray[i] = Employees[i];
            }
           tempArray[tempArray.Length - 1] = employee;
           Employees = tempArray;
        }

    }
}
