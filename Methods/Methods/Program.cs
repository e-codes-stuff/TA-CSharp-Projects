class Program
{
    static void Main(string[] args)
    {
        // Instantiate the Addition class
        Addition addition = new Addition();

        // Ask the user for the first number
        Console.WriteLine("Enter the first number:");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        // Ask the user for the second number, noting it's optional
        Console.WriteLine("Enter the second number (press Enter to skip):");
        string secondNumberInput = Console.ReadLine();

        // Check if the user entered a second number and call the Add method accordingly
        if (string.IsNullOrEmpty(secondNumberInput))
        {
            // Call the method with one argument
            int result = addition.Add(firstNumber);
            Console.WriteLine($"Result: {result}");
        }
        else
        {
            // Convert the second input to an integer and call the method with two arguments
            int secondNumber = Convert.ToInt32(secondNumberInput);
            int result = addition.Add(firstNumber, secondNumber);
            Console.WriteLine($"Result: {result}");
        }
    }
}
