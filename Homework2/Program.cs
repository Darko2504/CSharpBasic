#region first task

        int[] numbers = new int[6];
        
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter integer no.{i + 1}: ");
    bool tryParsed = int.TryParse(Console.ReadLine(), out int parsedNumber);
            numbers[i] = parsedNumber;
        }

        int sumOfEvens = 0;
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                sumOfEvens += number;
            }
        }

        Console.WriteLine($"The result is: {sumOfEvens}");

#endregion

#region second task
string[] studentsG1 = new string[] {"Darko", "Marko", "Parko", "Sharko", "Dzarko" };

string[] studentsG2 = new string[] { "Dzvonko", "Petko", "Stanko", "Branko", "Trajko" };

Console.WriteLine("Please enter the group you want to be displayed.(1 or 2 are only available!)");
bool inputGroup = int.TryParse(Console.ReadLine(), out int numberGroup);
if(numberGroup == 1)
{
    Console.WriteLine("The students in G1 are: ");
    foreach(string student in studentsG1)
    {
        Console.WriteLine(student);
    }
}
else if(numberGroup == 2)
{
    Console.WriteLine("The students in G2 are: ");
    foreach(string student in studentsG2)
    {
        Console.WriteLine(student);
    }
}
else
{
    Console.WriteLine("Group not available!!");
}


#endregion

#region third task
string[] names = new string[100];
int count = 0;
string continueInput; 
Console.WriteLine("Enter a name: ");

while (true)
{
    string input = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(input)) 
    {
        
        Array.Resize(ref names, count + 1);
        names[count] = input; 
        count++;
    }
    else
    {
        Console.WriteLine("Name cannot be empty. Please enter a valid name.");
        continue;
    }

    Console.WriteLine("Do you want to enter another name? (Y/N): ");
    continueInput = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(continueInput))
    {
        Console.WriteLine("Please enter a valid key!");
    }
    if(continueInput.ToUpper() != "Y" && continueInput.ToUpper() == "N" )
    {
        break;
    }
   
}

Console.WriteLine("\nThe names entered are:");
for (int i = 0; i < count; i++)
{
    Console.WriteLine(names[i]);
}
    
#endregion