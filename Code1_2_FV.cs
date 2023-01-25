            bool exit = false;

            do
            {
                // 6th PART
                Console.WriteLine("Please select one of the exercises you'd like to try:");
                Console.WriteLine("1. Input 4 numbers. See which one is the highest.");
                Console.WriteLine("2. Input 2 numbers. See which will have the highest result after dividing them.");
                Console.WriteLine("3. Input 4 numbers. See which one is the lowest after dividing them by the remainding ones.");
                Console.WriteLine("4. Input 2 numbers. See the result of their division, with 2 decimal places.");
                Console.WriteLine("5. Input 2 numbers. See if its even (Bizz) or odd (Buzz) after multiplying them.");
                Console.WriteLine("6. Input 2 numbers and one math operation. See the result of the operation chosen with the input numbers.");
                Console.WriteLine("0. Exit the menu.");
                Console.WriteLine();
                int menuSelection = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (menuSelection)
                {
                    case 0:
                        exit = true;
                        break;

                    case 1:
                        // 1st PART
                        Console.WriteLine("First Exercise: Input 4 numbers. See which one is the highest.\n");
                        Console.WriteLine("Please input your first number:");
                        int firstNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please input your second number:");
                        int secondNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please input your third number:");
                        int thirdNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please input your fourth number:");
                        int fourthNumber = int.Parse(Console.ReadLine());

                        // LISTA VARIÁVEIS
                        List<int> numbersList = new List<int> { firstNumber, secondNumber, thirdNumber, fourthNumber };
                        // numbersList.Add(firstNumber);
                        // numbersList.Add(secondNumber);
                        // numbersList.Add(thirdNumber);
                        // numbersList.Add(fourthNumber);

                        // MAX VALUE LISTA 
                        Console.Write("The Highest value input was: " + numbersList.Max());
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Beep();

                        Console.WriteLine("Would you like to see the Menu again? (Y/N)");
                        string menuAgain1 = Console.ReadLine().ToUpper();

                        if (menuAgain1 == "N")
                        {
                            exit = true;
                        }

                        Console.WriteLine("");
                        Console.Clear();

                        break;

                    case 2:
                        // 2nd PART
                        Console.WriteLine("Second Exercise: Input 2 numbers. See which will have the highest result after dividing them.\n");
                        Console.WriteLine("Please input your first number:");
                        int fifthNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please input your second number:");
                        int sixthNumber = int.Parse(Console.ReadLine());
                        double firstDivision = fifthNumber / sixthNumber;
                        double secondDivision = sixthNumber / fifthNumber;
                        if (firstDivision > secondDivision)
                        {
                            Console.WriteLine($"The highest number obtained from the division of both inputs is: {firstDivision}");
                        }
                        else
                        {
                            Console.WriteLine($"The highest number obtained from the division of both inputs is: {secondDivision}");
                        }
                        Console.WriteLine();
                        Console.Beep();

                        Console.WriteLine("Would you like to see the Menu again? (Y/N)");
                        string menuAgain2 = Console.ReadLine().ToUpper();

                        if (menuAgain2 == "N")
                        {
                            exit = true;
                        }

                        Console.WriteLine("");
                        Console.Clear();

                        break;

                    case 3:
                        // 3rd PART
                        Console.WriteLine("Third Exercise: Input 4 numbers. See which one is the lowest after dividing them by the remainding ones.\n");
                        Console.WriteLine("Please input your first number:");
                        int seventhNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please input your second number:");
                        int eighthNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please input your third number:");
                        int ninethNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please input your fourth number:");
                        int tenthNumber = int.Parse(Console.ReadLine());
                        double thirdDivision = seventhNumber / (eighthNumber + ninethNumber + tenthNumber);
                        double fourthDivision = eighthNumber / (seventhNumber + ninethNumber + tenthNumber);
                        double fifthDivision = ninethNumber / (seventhNumber + eighthNumber + tenthNumber);
                        double sixthDivision = tenthNumber / (seventhNumber + eighthNumber + ninethNumber);

                        // LISTA DIVISÕES
                        List<double> divisionsList = new List<double> { thirdDivision, fourthDivision, fifthDivision, sixthDivision };

                        // MIN VALUE LIST
                        Console.Write($"The Minimum value operations done is: " + divisionsList.Min());
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Beep();

                        Console.WriteLine("Would you like to see the Menu again? (Y/N)");
                        string menuAgain3 = Console.ReadLine().ToUpper();

                        if (menuAgain3 == "N")
                        {
                            exit = true;
                        }

                        Console.WriteLine("");
                        Console.Clear();

                        break;

                    case 4:
                        // 4th PART
                        Console.WriteLine("Fourth Exercise: Input 2 numbers. See the result of their division, with 2 decimal places.\n");
                        Console.WriteLine("Please input your first number:");
                        double eleventhNumber = double.Parse(Console.ReadLine());
                        Console.WriteLine("Please input your second number:");
                        double twelfthNumber = double.Parse(Console.ReadLine());
                        double seventhDivision = eleventhNumber / twelfthNumber;
                        Console.WriteLine($"The result of the division is: {seventhDivision.ToString("0.00")}");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Beep();

                        Console.WriteLine("Would you like to see the Menu again? (Y/N)");
                        string menuAgain4 = Console.ReadLine().ToUpper();

                        if (menuAgain4 == "N")
                        {
                            exit = true;
                        }

                        Console.WriteLine("");
                        Console.Clear();

                        break;

                    case 5:
                        // 5th PART
                        Console.WriteLine("Fifth Exercise: Input 2 numbers. See if its even (Bizz) or odd (Buzz) after multiplying them.\n");
                        Console.WriteLine("Please input your first number:");
                        int thirteenthNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please input your second number:");
                        int fourteenthNumber = int.Parse(Console.ReadLine());
                        int firstMultiplication = thirteenthNumber * fourteenthNumber;
                        if (firstMultiplication % 2 == 0)
                        {
                            Console.WriteLine("Bizz");
                        }
                        else
                        {
                            Console.WriteLine("Buzz");
                        }

                        Console.WriteLine("Would you like to see the Menu again? (Y/N)");
                        string menuAgain5 = Console.ReadLine().ToUpper();

                        if (menuAgain5 == "N")
                        {
                            exit = true;
                        }

                        Console.WriteLine("");
                        Console.Clear();

                        break;

                    case 6:
                        //7th PART
                        Console.WriteLine("Sixth Exercise: Input 2 numbers and one math operation. See the result of the operation chosen with the input numbers.\n");
                        Console.WriteLine("Please input your first number:");
                        int fifteenthNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please input your second number:");
                        int sixteenthNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Choose one of the following math operations:");
                        Console.WriteLine("SUM - Adding the first number to the second one.");
                        Console.WriteLine("SUB - Subtracting the first number to the second one.");
                        Console.WriteLine("MLT - Multiplying the first number to the second one.");
                        Console.WriteLine("DIV - Dividing the first number to the second one.\n");
                        string operationNumber = Console.ReadLine().ToUpper();

                        switch (operationNumber)
                        {
                            case "SUM":
                                int sumLastExercise = fifteenthNumber + sixteenthNumber;
                                Console.WriteLine($"The result of the SUM was: {sumLastExercise}\n");
                                Console.Beep();
                                break;

                            case "SUB":
                                int subLastExercise = fifteenthNumber - sixteenthNumber;
                                Console.WriteLine($"The result of the SUBtraction was: {subLastExercise}\n");
                                Console.Beep();
                                break;

                            case "MLT":
                                int mltLastExercise = fifteenthNumber * sixteenthNumber;
                                Console.WriteLine($"The result of the MLTplication was: {mltLastExercise}\n");
                                Console.Beep();
                                break;

                            case "DIV":
                                double divLastExercise = fifteenthNumber / sixteenthNumber;
                                Console.WriteLine($"The result of the DIVision was: {divLastExercise}\n");
                                Console.Beep();
                                break;

                            default:
                                Console.WriteLine("");
                                Console.WriteLine("Sorry but the Math operator chosen is not valid. Try again from the Main Menu.");
                                break;
                        }

                        Console.WriteLine("Would you like to see the Main Menu? (Y/N)");
                        string menuAgain6 = Console.ReadLine().ToUpper();

                        if (menuAgain6 == "N")
                        {
                            exit = true;
                        }

                        Console.WriteLine("");
                        Console.Clear();

                        break;

                    default:
                        break;
                }

            } while (!exit);

            Console.WriteLine("I hope you liked the program and hope to see you again!");
