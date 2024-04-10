// Declaring the class as static
static class MathOperations
{
    // Method to divide the input by two
    // This method demonstrates the use of output parameters
    public static void DivideByTwo(int input, out int result)
    {
        result = input / 2;
    }

    // Overloaded method to demonstrate method overloading
    // This version takes a double as an input
    public static void DivideByTwo(double input, out double result)
    {
        result = input / 2.0;
    }
}
