Console.WriteLine("Please insert your first name: ");
string firstName = Console.ReadLine();
Console.WriteLine("Please insert your middle name: ");
string middleName = Console.ReadLine();
Console.WriteLine("Please insert your last name: ");
string lastName = Console.ReadLine();
Console.WriteLine("Is your full name {0} {1} {2}? (y/n)", firstName, middleName, lastName);
string answer = Console.ReadLine();
if (answer == "n")
{
Console.WriteLine("Please insert your full name: ");
}
string fullName = Console.ReadLine();
Console.WriteLine("Please insert your gender: ");
string gender = Console.ReadLine();
Console.WriteLine("Please insert your birthdate: (dd/mm/yyyy)");
string birthdate = Console.ReadLine();
Console.WriteLine("Please insert your current job: ");
string currentJob = Console.ReadLine();
Console.WriteLine("Please insert your height: (ex: 1,67)");
string height = Console.ReadLine();
Console.WriteLine("Please insert your eye colour: ");
string eyeColour = Console.ReadLine();
int birthYear = int.Parse(birthdate[^4..]);
int birthDay = int.Parse(birthdate[..2]);
string birthMonth = birthdate.Substring(3,2);

switch (birthMonth)
{
    case "01":
        birthMonth = "January";
        break;
    case "02":
        birthMonth = "February";
        break;
    case "03":
        birthMonth = "March";
        break;
    case "04":
        birthMonth = "April";
        break;
    case "05":
        birthMonth = "May";
        break;
    case "06":
        birthMonth = "June";
        break;
    case "07":
        birthMonth = "July";
        break;
    case "08":
        birthMonth = "August";
        break;
    case "09":
        birthMonth = "September";
        break;
    case "10":
        birthMonth = "October";
        break;
    case "11":
        birthMonth = "November";
        break;
    case "12":
        birthMonth = "December";
        break;
}     

Console.WriteLine();
//a
Console.WriteLine("Your first name is {0}.", firstName);
//b
Console.WriteLine("Your middle name is {0}.", middleName);
//c
Console.WriteLine("Your last name is {0}.", lastName);
//d
if (answer == "y")
{
    Console.WriteLine("Your full name is {0} {1} {2}.", firstName, middleName, lastName);
}
else
{
    Console.WriteLine("Your full name is {0}.", fullName);
}
//e
Console.WriteLine("Your gender is {0}.", gender);
//f
Console.WriteLine("You are " + (2022 - birthYear) + " years old.");
//g
if (birthDay == 01 || birthDay == 21 || birthDay == 31)
{
    Console.WriteLine("Your birthdate is {0}st of {1} of {2}.", birthDay, birthMonth, birthYear);
}
else if (birthDay == 02 || birthDay == 22)
{ 
    Console.WriteLine("Your birthdate is {0}nd of {1} of {2}.", birthDay, birthMonth, birthYear);
}
else if (birthDay == 03 || birthDay == 23)
{ 
    Console.WriteLine("Your birthdate is {0}rd of {1} of {2}.", birthDay, birthMonth, birthYear);
}
else
{
    Console.WriteLine("Your birthdate is {0}th of {1} of {2}.", birthDay, birthMonth, birthYear);
}
//h
Console.WriteLine("Your current job is {0}.", currentJob);
//i
Console.WriteLine("Your current height is {0} meters", height;
//j
Console.WriteLine("Your eye colour is {0}.", eyeColour);
