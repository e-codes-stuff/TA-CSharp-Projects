class MathOperations
{
    // Method that takes an integer, adds 10, and returns an integer
    public int PerformOperation(int number)
    {
        return number + 10;
    }

    // Method that takes a decimal, performs subtraction, and returns the result as an integer
    public int PerformOperation(decimal number)
    {
        return (int)(number - 2.5m);
    }

    // Method that takes a string, converts it to an integer, and returns the number * 3
    public int PerformOperation(string number)
    {
        int convertedNumber = int.Parse(number);
        return convertedNumber * 3;
    }
}
