int count = 0;

// Demonstrating a boolean comparison using a while statement
// This loop will run as long as count is less than 5
while (count < 5)
{
    Console.WriteLine($"While Loop Iteration: {count + 1}");
    count++;
}

// Separating the examples for clarity
Console.WriteLine("End of while loop example.\n");

// Resetting count for the do-while example
count = 0;

// Demonstrating a boolean comparison using a do-while statement
// This loop will run at least once and continue as long as count is less than 5
do
{
    Console.WriteLine($"Do-While Loop Iteration: {count + 1}");
    count++;
} while (count < 5);

Console.WriteLine("End of do-while loop example.");