Console.WriteLine("Anonymous Income Comparison Program");

// Collect and calculate salary for Person 1
Console.WriteLine("Person 1");
Console.Write("Hourly Rate: ");
// Convert string inputs to decimal for accurate calculations
decimal hourlyRate1 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Hours worked per week: ");
int hoursWorkedPerWeek1 = Convert.ToInt32(Console.ReadLine());
decimal annualSalary1 = hourlyRate1 * hoursWorkedPerWeek1 * 52;

// Collect and calculate salary for Person 2
Console.WriteLine("Person 2");
Console.Write("Hourly Rate: ");
decimal hourlyRate2 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Hours worked per week: ");
int hoursWorkedPerWeek2 = Convert.ToInt32(Console.ReadLine());
decimal annualSalary2 = hourlyRate2 * hoursWorkedPerWeek2 * 52; // Calculate annual salary based on 52 weeks in a year

// Display annual salaries
Console.WriteLine($"Annual salary of Person 1: {annualSalary1}");
Console.WriteLine($"Annual salary of Person 2: {annualSalary2}");

// Display if Person 1 makes more money than Person 2
bool doesPerson1MakeMore = annualSalary1 > annualSalary2;
Console.WriteLine($"Does Person 1 make more money than Person 2? {doesPerson1MakeMore}");
