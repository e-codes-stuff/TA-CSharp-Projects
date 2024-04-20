    class ConstructorChaining
    {
        public string Message { get; set; }

        // Primary constructor that takes a message
        public ConstructorChaining(string message) : this(message, true)
        {
            // This constructor is intentionally left blank
        }

        // Secondary constructor that chains from the primary constructor
        public ConstructorChaining(string message, bool displayMessage)
        {
            Message = message;
            // Optionally display the message when the object is created
            if (displayMessage)
            {
                Console.WriteLine("Creating an instance with message: " + message);
            }
        }
    }