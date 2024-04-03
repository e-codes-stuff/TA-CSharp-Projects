Console.WriteLine("Enter a number to perform math operations on:");
int userNumber = Convert.ToInt32(Console.ReadLine());

// Create an instance of MathOperations
MathOperations operations = new MathOperations();

// Call the AddTen method
int resultAddTen = operations.AddTen(userNumber);
Console.WriteLine($"Adding 10 to your number: {resultAddTen}");

// Call the MultiplyByTwo method
int resultMultiplyByTwo = operations.MultiplyByTwo(userNumber);
Console.WriteLine($"Multiplying your number by 2: {resultMultiplyByTwo}");

// Call the SubtractFive method
int resultSubtractFive = operations.SubtractFive(userNumber);
Console.WriteLine($"Subtracting 5 from your number: {resultSubtractFive}");
