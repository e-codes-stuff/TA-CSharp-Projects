// Declaring the class as static
static class Program
{
    static void Main(string[] args)
    {
        // Instantiate the MathOperations class
        MathOperations calc = new MathOperations();

        // Prompt the user to enter a number
        Console.WriteLine("Please enter a number:");
        var number = int.Parse(Console.ReadLine());

        calc.DivideByTwo(number, out int int_result);
        Console.WriteLine($"The int result of dividing {number} by 2 is: {int_result}");

        
        calc.DivideByTwo((double)number, out double double_result);
        Console.WriteLine($"The double result of dividing {number} by 2 is: {double_result}");
    }
}
