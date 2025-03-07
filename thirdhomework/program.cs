
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your birthday (yyyy-mm-dd):");
        string input = Console.ReadLine();

        if (DateTime.TryParse(input, out DateTime birthday))
        {
            int age = AgeCalculator(birthday);
            Console.WriteLine($"Your age is: {age}");
        }
        else
        {
            Console.WriteLine("Invalid date format. Please enter the date in yyyy-mm-dd format.");
        }
    }

    public static int AgeCalculator(DateTime birthday)
    {
        DateTime today = DateTime.Today;
        int age = today.Year - birthday.Year;

        // Check if the birthday has occurred this year
        if (today < birthday.AddYears(age))
        {
            age--;
        }

        return age;
    }
