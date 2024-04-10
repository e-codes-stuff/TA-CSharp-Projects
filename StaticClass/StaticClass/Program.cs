static class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a number
        Console.WriteLine("Please enter a number:");
        var number = int.Parse(Console.ReadLine());

        MathOperations.DivideByTwo(number, out int int_result);
        Console.WriteLine($"The int result of dividing {number} by 2 is: {int_result}");

        
        MathOperations.DivideByTwo(number, out double double_result);
        Console.WriteLine($"The double result of dividing {number} by 2 is: {double_result}");

        var adder = new Adder();

        var result = adder.Add(number, 1);
        Console.WriteLine($"The result of the number + 1 is {result}");
    }
}
