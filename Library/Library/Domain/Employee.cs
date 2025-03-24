namespace Library.Domain
{
    public class Employee
    {

        public enum Role
        {
            Sales,
            Manager,
            Other
        }
        public Employee(string firstName, string lastName, double salary, Role role)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            EmployeeRole = role;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }       
        public Role EmployeeRole { get; set; }
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

