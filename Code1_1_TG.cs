Console.WriteLine("Please insert your first name: ");
string firstName = Console.ReadLine();
Console.WriteLine("Please insert your middle name: ");
string middleName = Console.ReadLine();
Console.WriteLine("Please insert your last name: ");
string lastName = Console.ReadLine();
Console.WriteLine("Plese insert your birth day: ");
int birthDay = int.Parse(Console.ReadLine());
Console.WriteLine("Please insert your birth month: ");
string birthMonth = Console.ReadLine();
Console.WriteLine("Please insert your birth year: ");
int birthYear = int.Parse(Console.ReadLine());
Console.WriteLine("Please insert your gender: ");
string gender = Console.ReadLine(); 
Console.WriteLine("Please insert your current job: ");
string currentJob = Console.ReadLine(); 
Console.WriteLine("Please insert your height: ");
float height = float.Parse(Console.ReadLine());
Console.WriteLine("Please insert your eye color: ");
string eyeColor = Console.ReadLine();
Console.WriteLine("Plese insert additional information: ");
string additionalInfo = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("This is an application to display user information:");
Console.WriteLine();
//A
Console.WriteLine("First name is " + firstName);
//B
Console.WriteLine("Middle name is " + middleName);
//C
Console.WriteLine("Last name is " + lastName);
//D
Console.WriteLine($"Full name is {firstName} {middleName} {lastName}" );
//E
Console.WriteLine("Gender is " + gender);
//F
Console.WriteLine("Age is " + (2022 - birthYear));
//G
//GX se não metes alternativa ao 3rd, todas as datas vão sair com esse formato. 
//Se não especificas o formato que queres o mês, vais ter gente a preencher 03 em vez de escrever Março
Console.WriteLine($"Birthdate is {birthDay}rd of {birthMonth} of {birthYear}");
//H
Console.WriteLine("Current job is " + currentJob);
//I
//GX Console.WriteLine("Current height is {0} meters", height);
Console.WriteLine("Current height is " + height + " meters");
//J
Console.WriteLine("Eye color is " + eyeColor);
//K
Console.WriteLine(additionalInfo);
