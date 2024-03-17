// Prompt user for input and multiply by 50, then print the result
Console.Write("Enter a number to multiply by 50: ");
long inputMultiply = Convert.ToInt64(Console.ReadLine());
Console.WriteLine($"Result after multiplying by 50: {inputMultiply * 50}");

// Prompt user for input, add 25 to it, then print the result
Console.Write("Enter a number to add 25 to: ");
long inputAdd = Convert.ToInt64(Console.ReadLine());
Console.WriteLine($"Result after adding 25: {inputAdd + 25}");

// Prompt user for input, divide by 12.5, then print the result
Console.Write("Enter a number to divide by 12.5: ");
double inputDivide = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Result after dividing by 12.5: {inputDivide / 12.5}");

// Prompt user for input, check if it's greater than 50, then print true/false
Console.Write("Enter a number to check if it's greater than 50: ");
long inputCheck = Convert.ToInt64(Console.ReadLine());
Console.WriteLine($"Is the number greater than 50? {inputCheck > 50}");

// Prompt user for input, divide by 7, then print the remainder
Console.Write("Enter a number to find the remainder when divided by 7: ");
long inputRemainder = Convert.ToInt64(Console.ReadLine());
Console.WriteLine($"Remainder when divided by 7: {inputRemainder % 7}");
