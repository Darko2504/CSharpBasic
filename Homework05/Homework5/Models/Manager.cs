
namespace Homework05.Models
{
   public class Manager : Employee
    {
        public Manager(string firstName, string lastName, double salary, string department)
          : base(firstName, lastName, salary)
        {
            Department = department;
        }
        public string Department { get; set; }

    }
}
