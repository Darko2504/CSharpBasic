
using Library.Domain;

Manager manager1 = new Manager("Darko", "Milanovski", 2000, "Sales");
Manager manager2 = new Manager("Robert", "Robertovski", 2500, "HR");

SalesPerson salesPerson = new SalesPerson("Elena", "Elenovska", 1800, Employee.Role.Sales, 22);

Contractor contractor1 = new Contractor("Igor", "Igorski", 40, 20, manager1);
Contractor contractor2 = new Contractor("Lea", "Leova", 35, 25, manager2);

Ceo ceo1 = new Ceo("Martin", "Panovski", 1500, 100, "Qinshift");
ceo1.AddSharesPrice(55);
ceo1.AddEmployee(manager1);
ceo1.AddEmployee(manager2);
ceo1.AddEmployee(salesPerson);
ceo1.AddEmployee(contractor1);
ceo1.AddEmployee(contractor2);



Manager manager3 = new Manager("Angel", "Ivanovski", 2100, "HR");
Manager manager4 = new Manager("Sandra", "Simjanoska", 2200, "Marketing");

SalesPerson salesPerson2 = new SalesPerson("Viktor", "Viktorski", 1500, Employee.Role.Sales, 10);

Contractor contractor3 = new Contractor("Tase", "Tasevski", 35, 15, manager3);
Contractor contractor4 = new Contractor("Vase", "Vasevski", 44, 17, manager4);

Ceo ceo2 = new Ceo("Mario", "Mariovski", 2555, 95, "SEMOS");
ceo2.AddSharesPrice(12);
ceo2.AddEmployee(manager3);
ceo2.AddEmployee(manager4);
ceo2.AddEmployee(salesPerson2);
ceo2.AddEmployee(contractor3);
ceo2.AddEmployee(contractor4);


Console.WriteLine("Please enter the name of the company so i show you the info of it! \n 1.Qinshift \n 2.SEMOS");
string userChoice = Console.ReadLine();

if (userChoice.ToLower() == "qinshift")
{
    Console.WriteLine("CEO:");
    ceo1.PrintInfo();
    Console.WriteLine($"Salary of CEO is: {ceo1.GetSalary()}");
    ceo1.PrintEmployees();
}
else if (userChoice.ToLower() == "semos")
{
    Console.WriteLine("CEO:");
    ceo2.PrintInfo();
    Console.WriteLine($"Salary of the CEO is: {ceo2.GetSalary()}");
    ceo2.PrintEmployees();
}
else
{
    Console.WriteLine("Not such company is enlisted! Please try again");
}