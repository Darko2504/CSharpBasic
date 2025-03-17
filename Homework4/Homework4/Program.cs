using Cars;
using Homework4.models;

Driver[] drivers =
{
    new Driver("Darko", 10),
    new Driver("Martin", 9),
    new Driver("Mario", 8),
    new Driver("Dzvonko", 7),
};

Car[] cars =
{
    new Car("Hyundai", 160),
    new Car("Mazda", 180),
    new Car("Ferrari", 290),
    new Car("Porsche", 270)
};


do
{
    Console.WriteLine("Welcome to the racing stimulator of NeedForSpeed");
    Console.WriteLine("Please choose 2 cars with it's driver and i will tell you which one is faster ");
    Console.WriteLine("Choose car number 1:");
    for (int i = 0; i < cars.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {cars[i].Model}");
    }
    int firstCarIndex = int.Parse(Console.ReadLine()) - 1;
    Car firstCar = cars[firstCarIndex];

    Console.WriteLine("Choose the first car's driver");
    for (int i = 0; i < drivers.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {drivers[i].Name}");
    }
    int firstDriverIndex = int.Parse(Console.ReadLine()) - 1;
    firstCar.Driver = drivers[firstCarIndex];


    Console.WriteLine("Choose car number 2");
    for (int i = 0; i < cars.Length; i++)
    {
        if (i != firstCarIndex)
        {
            Console.WriteLine($"{i + 1}. {cars[i].Model}");
        }
        
    }
    int secondCarIndex = int.Parse(Console.ReadLine()) - 1;
    Car secondCar = cars[secondCarIndex];

    Console.WriteLine("Choose the driver for the second car:");
    for (int i = 0; i < drivers.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {drivers[i].Name}");
    }

    int secondDriverIndex = int.Parse(Console.ReadLine()) - 1;
    secondCar.Driver = drivers[secondDriverIndex];

    RaceCars(firstCar, secondCar);

    Console.WriteLine("Do you want to race again? (yes/no)");

} while (Console.ReadLine().ToLower() == "yes");


static void RaceCars(Car firstCar, Car secondCar)
{
    int firstCarSpeed = firstCar.CalculateSpeed();
    int secondCarSpeed = secondCar.CalculateSpeed();

    if (firstCarSpeed > secondCarSpeed)
    {
        Console.WriteLine($"Car {firstCar.Model} was faster, going at {firstCar.Speed} km/h with driver {firstCar.Driver.Name}.");
    }
    else
    {
        Console.WriteLine($"Car {secondCar.Model} was faster, going at {secondCar.Speed} km/h with driver {secondCar.Driver.Name}.");
    }
}