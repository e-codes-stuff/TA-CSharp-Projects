class Program
{
    static void Main(string[] args)
    {
        MathOperationClass mathOperation = new MathOperationClass();
        
        // Calling the method with two numbers
        mathOperation.PerformOperation(5, 10);
        
        // Calling the method, specifying the parameters by name
        mathOperation.PerformOperation(num1: 3, num2: 6);
    }
}
