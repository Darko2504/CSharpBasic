
#region first task
Console.Write("Enter the First number: ");
decimal firstNumber = Convert.ToDecimal(Console.ReadLine());

Console.Write("Enter the Second number: ");
decimal secondNumber = Convert.ToDecimal(Console.ReadLine());

Console.Write("Enter the Operation: ");
string operation = Console.ReadLine();

decimal result = 0;

switch (operation)
{
    case "+":
        result = firstNumber + secondNumber;
        break;
    case "-":
        result = firstNumber - secondNumber;
        break;
    case "*":
        result = firstNumber * secondNumber;
        break;
    case "/":
        if (firstNumber == 0  || secondNumber == 0)
        {
            Console.WriteLine(" Division by zero is not allowed.");
            return;
        }
        result = firstNumber / secondNumber;
        break;
    default:
        Console.WriteLine("You have entered an invalid operation.");
        break;
}

Console.WriteLine("The result is:" + result);

#endregion

#region second task
Console.WriteLine("Enter the first number: ");
double firstNumberAv = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
double secondNumberAv = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the third number: ");
double thirdNumberAv = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the fourth number: ");
double fourthNumberAv = Convert.ToDouble(Console.ReadLine());

double average = (firstNumberAv + secondNumberAv + thirdNumberAv + fourthNumberAv) / 4;

Console.WriteLine("The average from these 4 numbers is: " + average);
#endregion

#region third task
Console.WriteLine("Enter the first number: ");
int firstNumberSwap = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int secondNumberSwap = int.Parse(Console.ReadLine());

int swappedNumber = firstNumberSwap;
firstNumberSwap = secondNumberSwap;
secondNumberSwap = swappedNumber;

Console.WriteLine("After swapping the numbers");
Console.WriteLine("First number is: " + firstNumberSwap);
Console.WriteLine("Second number is: " + secondNumberSwap);
#endregion