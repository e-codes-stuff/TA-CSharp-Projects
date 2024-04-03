class Program
{
    static void Main(string[] args)
    {
        // Create MathOperations
        MathOperations operations = new MathOperations();
        Console.WriteLine(operations.PerformOperation(5));
        Console.WriteLine(operations.PerformOperation(5.5m));
        Console.WriteLine(operations.PerformOperation("10"));
    }
}
