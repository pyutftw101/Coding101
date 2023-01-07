bool exit = false;
while (!exit)
{
    Console.WriteLine("Please select one exercise:");
    Console.WriteLine("Exercise 1");
    Console.WriteLine("Exercise 2");    
    Console.WriteLine("Exercise 3");
    Console.WriteLine("Exercise 4");
    Console.WriteLine("Exercise 5");
    Console.WriteLine("Exercise 6");
    Console.WriteLine();
    int option = int.Parse(Console.ReadLine());
    string input;
    Console.WriteLine();
    

    switch (option) {
    case 1:
            int firstNumber = 0;
            int secondNumber = 0;
            int thirdNumber = 0;
            int forthNumber = 0;
            Console.WriteLine("Exercise 1:");
        Console.WriteLine();
        Console.WriteLine("Please insert a number: ");
        firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please insert a number: ");
        secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please insert a number: ");
        thirdNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please insert a number: ");
        forthNumber = int.Parse(Console.ReadLine());

        var maxnumber = 0;
        if (firstNumber < secondNumber)
        {
            maxnumber = secondNumber;
        }
        else
        {
            maxnumber = firstNumber;
        }
        if (maxnumber < thirdNumber)
        {
            maxnumber = thirdNumber;
        }
        if (maxnumber < forthNumber)
        {
            maxnumber = forthNumber;
        }
        Console.WriteLine();
        Console.WriteLine("max number is equal to: {0}", maxnumber);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Executar outra vez (s/n): ");
            input = Console.ReadLine().ToLower();
            exit = !(input == "s");
            Console.WriteLine();
            break;

    case 2:
            
        Console.WriteLine("Exercise 2:");
        Console.WriteLine();
        Console.WriteLine("Please insert a number: ");
        double fifthNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Please insert a number: ");
        double sixtheNumber = double.Parse(Console.ReadLine());
        Console.WriteLine();
        double firstResult = fifthNumber / sixtheNumber;
        double secondResult = sixtheNumber / fifthNumber;
        double maxResult;

        Console.WriteLine(firstResult);
        Console.WriteLine();
        Console.WriteLine(secondResult);

        if (firstResult < secondResult)
        {
            maxResult = secondResult;
        }
        else
        {
            maxResult = firstResult;
        }
        Console.WriteLine();
        Console.WriteLine("Max resutl is {0}", maxResult);
        Console.WriteLine();Console.WriteLine("Executar outra vez (s/n): ");
            input = Console.ReadLine().ToLower();
            exit = !(input == "s");
            Console.WriteLine();
            break;

    case 3:
        Console.WriteLine("Exercise 3:");
        Console.WriteLine();
        Console.WriteLine("Please insert a number: ");
        int seventhNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please insert a number: ");
        int eigthNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please insert a number: :");
        int ninthNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please insert a number: ");
        int tenthNumber = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int firstNumberDivided = (eigthNumber + ninthNumber + tenthNumber) / seventhNumber;
        Console.WriteLine(firstNumberDivided);
        int secondNumberDivided = (seventhNumber + ninthNumber + tenthNumber) / eigthNumber;
        Console.WriteLine(secondNumberDivided);
        int thirdNumberDivided = (eigthNumber + tenthNumber + seventhNumber) / ninthNumber;
        Console.WriteLine(thirdNumberDivided);
        int forthNumberDivided = (eigthNumber + ninthNumber + seventhNumber) / tenthNumber;
        Console.WriteLine(forthNumberDivided);
        Console.WriteLine();

        var minimumNumber = 0;

        if (firstNumberDivided < secondNumberDivided)
        {
            minimumNumber = firstNumberDivided;
        }
        else
        {
            minimumNumber = secondNumberDivided;
        }
        if (minimumNumber > thirdNumberDivided)
        {
            minimumNumber = thirdNumberDivided;
        }
        if (minimumNumber > forthNumberDivided)
        {
            minimumNumber = forthNumberDivided;
        }

        Console.WriteLine();
        Console.WriteLine(minimumNumber);
        Console.WriteLine();
        Console.WriteLine("Executar outra vez (s/n): ");
            input = Console.ReadLine().ToLower();
            exit = !(input == "s");
            Console.WriteLine();
            break;

    case 4:

        Console.WriteLine("Exercise 4:");
        Console.WriteLine();
        Console.WriteLine("Please insert a number: ");
        double eleventhNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Please insert a number: ");
        double twelvethNumber = double.Parse(Console.ReadLine());

        double divOne = eleventhNumber / twelvethNumber;
        double divTwo = twelvethNumber / eleventhNumber;

        Console.WriteLine(divOne.ToString("0.00"));
        Console.WriteLine(divTwo.ToString("0.00"));
        Console.WriteLine("Executar outra vez (s/n): ");
            input = Console.ReadLine().ToLower();
            exit = !(input == "s");
            Console.WriteLine();
            break;

    case 5:
        Console.WriteLine("Exercise 5:");
        Console.WriteLine();
        Console.WriteLine("Please insert a number: ");
        int therteenthNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please insert a number: ");
        int fourteenthNumber = int.Parse(Console.ReadLine());

        int multOne = therteenthNumber * fourteenthNumber;

        if (multOne % 2 == 0)
        {
            Console.WriteLine("Bizz");
        }
        else
        {
            Console.WriteLine("Buzz");
        }
            Console.WriteLine("Executar outra vez (s/n): ");
            input = Console.ReadLine().ToLower();
            exit = !(input == "s");
            Console.WriteLine();
            break;

        case 6:
            Console.WriteLine("Exercise 6:");
            Console.WriteLine();
            Console.WriteLine("Please insert a number: ");
            double fifteenthNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please insert a number: ");
            double sixteenthNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please select an operator ");
            Console.WriteLine("SUM");
            Console.WriteLine("SUB");
            Console.WriteLine("MLT");
            Console.WriteLine("DIV");
            Console.WriteLine();
            string operatorOne = Console.ReadLine().ToLower();

            switch (operatorOne)
            {
                case "sum":
                    Console.WriteLine(fifteenthNumber + sixteenthNumber);
                    break;
                case "sub":
                    Console.WriteLine(fifteenthNumber - sixteenthNumber);
                    break;
                case "mlt":
                    Console.WriteLine(fifteenthNumber * sixteenthNumber);
                    break;
                case "div":
                    Console.WriteLine(fifteenthNumber / sixteenthNumber);
                    break;
            }
            Console.WriteLine("Executar outra vez (s/n): ");
            input = Console.ReadLine().ToLower();
            exit = !(input == "s");
            Console.WriteLine();
            break;

        default:
            {
                Console.WriteLine("Please incert a valid option: ");
                Console.WriteLine();
            }

       break;
    }  
}
}
