Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

// Prompt user for package weight and store it
Console.WriteLine("Please enter the package weight:");
double weight = Convert.ToDouble(Console.ReadLine());

// Check if weight is over 50 and display error message if true, then end program
if (weight > 50)
{
    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
    return;
}

// Prompt the user for package info and store it in the proper type
Console.WriteLine("Please enter the package width:");
double width = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter the package height:");
double height = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter the package length:");
double length = Convert.ToDouble(Console.ReadLine());

// Check if the total of dimensions is over 50 and display error message if true, then end program
if ((width + height + length) > 50)
{
    Console.WriteLine("Package too big to be shipped via Package Express.");
    return;
}

// Calculate the quote by multiplying dimensions, weight, and then dividing by 100
double quote = (width * height * length * weight) / 100;

// Display the quote as a dollar amount
Console.WriteLine($"Your estimated total for shipping this package is: ${quote:0.00}");
Console.WriteLine("Thank you!");
