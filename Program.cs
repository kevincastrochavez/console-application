// 2.Store variables
Console.Write("Please enter your name: ");
string name = Console.ReadLine();


Console.Write("Please enter your location: ");
string location = Console.ReadLine();

// 3.Output WriteLine statement
Console.WriteLine($"My name is {name}, I am from {location}");

DateTime today = DateTime.Now;
int year = today.Year;
int yearDay = today.DayOfYear;
var christmasDay = new DateTime(year, 12, 25).DayOfYear;
int numberOfDaysUntilChristmas = christmasDay - yearDay;

// 4.Output current date but not time
Console.WriteLine($"The current date is: {today.ToShortDateString()}");

// 5.Output number of days until Christmas
if (numberOfDaysUntilChristmas == 0) {
    Console.WriteLine("Merry Christmas!");
} else if (numberOfDaysUntilChristmas < 0) {
    Console.WriteLine("Christmas just happened! Did you miss it?");
} else {
    Console.WriteLine($"The number of days until Christmas this year is {numberOfDaysUntilChristmas}");
}

// 6.Add the program example from section 2.1 in the C# Programming Yellow Book
double width, height, woodLength, glassArea;
string widthString, heightString;

// 7.Provide appropriate text labels and cause the program to pause in the console
Console.Write("Enter the width in numbers: ");
widthString = Console.ReadLine();
width = double.Parse(widthString);

Console.Write("Enter the height in numbers: ");
heightString = Console.ReadLine();
height = double.Parse(heightString);

woodLength = 2 * (width + height) * 3.25 ;
glassArea = 2 * (width * height) ;
Console.WriteLine($"The length of the wood is {woodLength} feet" ) ;
Console.WriteLine($"The area of the glass is {glassArea}");

Console.ReadKey();