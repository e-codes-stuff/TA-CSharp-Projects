List<string> stringList = new List<string> { "First", "Second", "Third", "Fourth", "Second" };

// Displaying the list elements
foreach (string item in stringList)
{
    Console.WriteLine($"List Item: {item}");
}

Console.WriteLine("Please input some text to search for in the list:");
string userInput = Console.ReadLine();

bool isFound = false;
List<int> matchingIndices = new List<int>();

// Loop to iterate through the list and find all matches
for (int i = 0; i < stringList.Count; i++)
{
    if (stringList[i].Contains(userInput))
    {
        matchingIndices.Add(i);
        isFound = true;
    }
}

if (isFound)
{
    Console.WriteLine("Matching text found at indices: " + string.Join(", ", matchingIndices));
}
else
{
    Console.WriteLine("Your input is not on the list.");
}

Console.WriteLine("\nChecking for duplicates in a list");

// Create a list of strings with at least two identical strings
List<string> fruitList = new List<string> { "Apple", "Banana", "Cherry", "Date", "Banana" };

// Create a HashSet to store unique items for comparison
HashSet<string> uniqueFruits = new HashSet<string>();

// Foreach loop to evaluate each item in the list
foreach (string item in fruitList)
{
    // Check if the item has already appeared in the HashSet
    // If Add returns false, the item is a duplicate
    if (!uniqueFruits.Add(item))
    {
        // Display message for duplicate item
        Console.WriteLine(item + " - this item is a duplicate");
    }
    else
    {
        // Display message for unique item
        Console.WriteLine(item + " - this item is unique");
    }
}

Console.WriteLine("\nEntering a loop...");

// To ensure this infinite loop does not run forever, we can add a condition to break out of the loop.
bool keepRunning = true;
while (keepRunning)
{
    // Condition to change keepRunning to false, breaking the loop
    Console.WriteLine("Type 'exit' to exit the program");
    string exitCommand = Console.ReadLine();
    if (exitCommand.ToLower() == "exit")
    {
        keepRunning = false;
    }
}
