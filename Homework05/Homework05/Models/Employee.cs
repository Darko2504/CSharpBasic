
namespace Homework05.Models
{
   public class Employee
    {
        public Employee(string firstName, string lastName, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public virtual double GetSalary()
        {
            return Salary;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"First Name: {FirstName}, Last Name: {LastName}, Salary:{Salary}");
        }
    }
}
