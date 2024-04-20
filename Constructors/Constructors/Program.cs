namespace Constructors
{
    class Program
    {
        // Constant variable declaration
        const string WelcomeMessage = "Welcome to the Constructor Chaining Example!";

        static void Main(string[] args)
        {
            // Using var to infer the type of the variable
            var example = new ConstructorChaining("Hello, World!");

            // Display the constant message
            Console.WriteLine(WelcomeMessage);
            // Display the message from the ConstructorChaining instance
            Console.WriteLine(example.Message);
        }
    }
}
