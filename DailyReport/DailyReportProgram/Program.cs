Console.WriteLine("The Tech Academy\nStudent Daily Report");

// Ask questions
Console.WriteLine("What is your name?");
var name = Console.ReadLine();

Console.WriteLine("What course are you on?");
var course = Console.ReadLine();

// Ask for page number and convert to Int32
Console.WriteLine("What page number are you on?");
var page_number = Convert.ToInt32(Console.ReadLine());

// Ask if help is needed and convert answer to bool
Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
var help_needed = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
var positive_experiences = Console.ReadLine();

Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
var other_feedback = Console.ReadLine();

Console.WriteLine("How many hours did you study today?");
var hours_studied = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");