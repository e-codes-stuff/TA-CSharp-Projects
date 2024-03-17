// Asks a question to the user
string ask_question(string question)
{
    Console.WriteLine(question);
    var answer = Console.ReadLine();

    // If there is no answer given (null or empty response)
    // ask again until one is entered
    while (answer == null || answer == "")
    {
        Console.WriteLine("Please answer the prompt:");
        Console.WriteLine(question);

        // Set answer to new input
        answer = Console.ReadLine();
    }

    return answer;
}

Console.WriteLine("The Tech Academy\nStudent Daily Report");

// Ask questions
var name = ask_question("What is your name?");
var course = ask_question("What course are you on?");
var page_number = ask_question("What page number are you on?");

// Ask if help is needed and ensure answer provided is true or false
var help_needed = ask_question("Do you need help with anything? Please answer \"true\" or \"false\"");
while (help_needed != "true" && help_needed != "false")
{
    help_needed = ask_question("Do you need help with anything? Please answer \"true\" or \"false\"");
}

var positive_experiences = ask_question("Were there any positive experiences you’d like to share? Please give specifics.");
var other_feedback = ask_question("Is there any other feedback you’d like to provide? Please be specific.");
var hours_studied = ask_question("How many hours did you study today?");

Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");