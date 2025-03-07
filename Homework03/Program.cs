
    int AgeCalculator(DateTime birthday)
    {
        DateTime today = DateTime.Today;
        int age = today.Year - birthday.Year;

        if (today < birthday.AddYears(age))
        {
            age--;
        }
    else if(birthday.DayOfYear == today.DayOfYear)
    {
        Console.WriteLine("Happy birthday to you!!");
    }

        return age;
    }

        Console.WriteLine("Enter your birthday (yyyy-mm-dd):");
        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
        {
    Console.WriteLine("Please enter valid date");
        }
        if (DateTime.TryParse(input, out DateTime birthday))
        {
            int age = AgeCalculator(birthday);
            Console.WriteLine($"Your age is: {age}");
        }
        else
        {
            Console.WriteLine("Invalid date format. Please enter the date in yyyy-mm-dd format.");
        }
