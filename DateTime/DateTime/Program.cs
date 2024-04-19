namespace DateTime
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Print the current date and time to the console
            Console.WriteLine("Current date and time: " + DateTime.Now.ToString());

            // Ask the user for a number
            Console.Write("Please enter a number of hours: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            // Calculate and print the exact time it will be in X hours
            DateTime futureTime = DateTime.Now.AddHours(hours);
            Console.WriteLine($"In {hours} hours, it will be: {futureTime}");
        }
    }

}
