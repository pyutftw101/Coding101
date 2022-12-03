// INPUT FROM HERE
Console.WriteLine("Please tell us your first name");
string firstName = Console.ReadLine();
Console.WriteLine("Your middle name as well");
string middleName = Console.ReadLine();
Console.WriteLine("Your last name too");
string lastName = Console.ReadLine();
string sumNames = (firstName + middleName + lastName);
Console.WriteLine("Either way, confirm your full name.");
string fullName = Console.ReadLine();
Console.WriteLine("What gender are you?");
string genderUser = Console.ReadLine();
Console.WriteLine("What day were you born? (DD)");
int birthDay = int.Parse(Console.ReadLine());
Console.WriteLine("What about the month? (MM)");
string birthMonth = Console.ReadLine();
Console.WriteLine("And the year? (YYYY)");
int birthYear = int.Parse(Console.ReadLine());
var dateToday = DateTime.Today;
var ageUser = dateToday.Year - birthYear;
Console.WriteLine("What do you do for a living?");
string jobUser = Console.ReadLine();
Console.WriteLine("What's your height? In meters with two decimal numbers please. And use a comma ffs. (X,XX)");
double heightUser = double.Parse(Console.ReadLine());
Console.WriteLine("And what about your eye colour?");
string eyeColourUser = Console.ReadLine();
Console.Clear();

// OUTPUT FROM HERE
Console.WriteLine("Now that we are finished with our questions, this is the result.");
Console.WriteLine();
Console.WriteLine("This is an application to display user information:");
Console.WriteLine();
Console.WriteLine($"The users first name is {firstName}.");
Console.WriteLine($"The users middle name is {middleName}.");
Console.WriteLine($"The users last name is {lastName}.");

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
if (sumNames == fullName)
{
    Console.WriteLine($"The users full name is {sumNames}");
}
else
{
    Console.WriteLine($"The users full name is {fullName}.");
}
Console.WriteLine($"The users gender is {genderUser}.");
Console.WriteLine($"The users age is {ageUser}.");
if (birthDay == 01 || birthDay == 21 || birthDay == 31)
{
    Console.WriteLine("The users birthdate is {0}st of {1} of {2}.", birthDay, birthMonth, birthYear);
}
else if (birthDay == 02 || birthDay == 22)
{
    Console.WriteLine("The users birthdate is {0}nd of {1} of {2}.", birthDay, birthMonth, birthYear);
}
else if (birthDay == 03 || birthDay == 23)
{
    Console.WriteLine("The users birthdate is {0}rd of {1} of {2}.", birthDay, birthMonth, birthYear);
}
else
{
    Console.WriteLine("The users birthdate is {0}th of {1} of {2}.", birthDay, birthMonth, birthYear);
}
Console.WriteLine($"The users current job is {jobUser}.");
Console.WriteLine($"The users height is {heightUser} meters.");
Console.WriteLine($"The users eye colour is {eyeColourUser}.");
