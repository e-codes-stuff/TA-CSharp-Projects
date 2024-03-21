// Create a one-dimensional array of strings
string[] stringArray = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

// Ask the user to select an index of the string array
Console.WriteLine("Select an index of the string array (0-4):");
int stringIndex = Convert.ToInt32(Console.ReadLine());

// Display the string at the selected index or an error message if the index doesn't exist
if (stringIndex >= 0 && stringIndex < stringArray.Length)
{
    Console.WriteLine($"Selected string: {stringArray[stringIndex]}");
}
else
{
    Console.WriteLine("Error: Index does not exist.");
}

// Create a one-dimensional array of integers
int[] intArray = { 5, 10, 15, 20, 25 };

// Ask the user to select an index of the integer array
Console.WriteLine("\nSelect an index of the integer array (0-4):");
int intIndex = Convert.ToInt32(Console.ReadLine());

// Display the integer at the selected index or an error message if the index doesn't exist
if (intIndex >= 0 && intIndex < intArray.Length)
{
    Console.WriteLine($"Selected integer: {intArray[intIndex]}");
}
else
{
    Console.WriteLine("Error: Index does not exist.");
}

// Create a list of strings
List<string> stringList = new List<string> { "Red", "Green", "Blue", "Yellow", "Purple" };

// Ask the user to select an index of the list
Console.WriteLine("\nSelect an index of the string list (0-4):");
int listIndex = Convert.ToInt32(Console.ReadLine());

// Display the content at the selected index or an error message if the index doesn't exist
if (listIndex >= 0 && listIndex < stringList.Count)
{
    Console.WriteLine($"Selected color: {stringList[listIndex]}");
}
else
{
    Console.WriteLine("Error: Index out of range.");
}
