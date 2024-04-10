class Employee : IQuittable
{
    // Implement the Quit method from the IQuittable interface
    public void Quit()
    {
        Console.WriteLine("Employee has quit.");
    }
}