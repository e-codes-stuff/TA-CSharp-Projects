// Ask the user for the required data
Console.WriteLine("What is your age?");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Have you ever had a DUI?");
bool hasDUI = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine("How many speeding tickets do you have?");
int speedingTickets = Convert.ToInt32(Console.ReadLine());

// Determine if the applicant:
// - Is over 15 years old
// - Does not have any DUIs
// - Does not have more than 3 speeding tickets
bool isQualified = age > 15 && !hasDUI && speedingTickets <= 3;

// Print the result of the qualification check
Console.WriteLine($"Qualified?\n{isQualified}");