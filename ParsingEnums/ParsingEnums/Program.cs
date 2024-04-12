// Define an enum for the days of the week
enum DayOfWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the current day of the week:");

        try
        {
            // Assign the value to a variable of the DayOfWeek enum data type
            DayOfWeek currentDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine(), true);
            Console.WriteLine($"You entered: {currentDay}");
        }
        catch
        {
            // If an error occurs, print this message to the console
            Console.WriteLine("Please enter an actual day of the week.");
        }
    }
}
