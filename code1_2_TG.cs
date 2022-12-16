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


Console.WriteLine("Please insert first number: ");
double thirdNumber = double.Parse(Console.ReadLine());
Console.WriteLine("Please insert second number: ");
double fourthNumber = double.Parse(Console.ReadLine());

double divOne= thirdNumber/fourthNumber;
double divTwo= fourthNumber/thirdNumber;

Console.WriteLine(divOne.ToString("0.00"));
Console.WriteLine(divTwo.ToString("0.00"));

Console.WriteLine("Please insert first number: ");
int fifthNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Please insert second number: ");
int sixthNumber = int.Parse(Console.ReadLine());

int multOne = fifthNumber * sixthNumber;

if (multOne%2 == 0)
{
    Console.WriteLine("Bizz");
}
else
{
    Console.WriteLine("Buzz");
}
