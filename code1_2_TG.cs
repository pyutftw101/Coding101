Console.WriteLine("Please insert first number: ");
double firstNumber = double.Parse(Console.ReadLine());
Console.WriteLine("Please insert sercond number");
double secondNumber = double.Parse(Console.ReadLine());
Console.WriteLine();
double firstMax;
double secondMax;
Console.WriteLine(firstMax = firstNumber/secondNumber);
Console.WriteLine(secondMax= secondNumber/firstNumber);
double maxResult;
if (firstMax > secondMax)
{
    maxResult = firstMax;
}
else
{
    maxResult = secondMax;
}
Console.WriteLine(maxResult);
