
#region first exercise
int branches = 12;
int applesPerBranch = 8;
int basketCapacity = 5;

Console.Write("Enter the number of trees: ");
int numberOfTrees = int.Parse(Console.ReadLine());

int totalApplesPerTree = branches * applesPerBranch;

int totalApples = totalApplesPerTree * numberOfTrees;

int basketsRequired = totalApples / basketCapacity;

Console.WriteLine("Baskets required for:" + numberOfTrees + " trees is:" + basketsRequired);

#endregion

#region second exercise
Console.WriteLine("Enter the first number:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number:");
int b = int.Parse(Console.ReadLine());
if(a % 2 == 0)
{
    Console.WriteLine("The number " + a + " is even");
}
else
{
    Console.WriteLine("The number " + b + " is odd");
}
if(b % 2 == 0)
{
    Console.WriteLine("The number " + b + " is even");
}
else
{
    Console.WriteLine("The number " + b + " is odd");
}
if(a > b)
{
    Console.WriteLine("The larger number from the two is " + a);
}
else if(b > a)
{
    Console.WriteLine("The larger number from the two is " + b);
}
else if(a == b)
{
    Console.WriteLine("The numbers have the same value");
}
#endregion