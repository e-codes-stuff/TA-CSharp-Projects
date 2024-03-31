List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

Console.WriteLine("Please enter a number to divide each number in the list by:");
try
{
    // Convert user input into an integer and 
    // divide each number by the user's number and display the result
    int divisor = Convert.ToInt32(Console.ReadLine());
    foreach (int number in numbers)
    {
        Console.WriteLine($"{number} divided by {divisor} equals {number / divisor}");
    }
}
catch (DivideByZeroException e)
{
    // Catch and display the error if a divide by zero is attempted
    Console.WriteLine("Error: Cannot divide by zero. Please try again with a non-zero number.");
}
catch (FormatException e)
{
    // Catch and display the error if the input is not a valid integer
    Console.WriteLine("Error: Please enter a valid number.");
}
finally
{
    // This block is executed regardless of the try/catch outcome
    Console.WriteLine("The program has continued execution beyond the try/catch block.");
}
