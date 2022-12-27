// PARTE I e II //

Console.Write("Please provide a number that you want to multiply: ");
		int number = int.Parse(Console.ReadLine());
        
 for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }
}
