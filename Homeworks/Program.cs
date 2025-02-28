//dare
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