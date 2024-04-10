class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee()
        {
            firstName = "Sample",
            lastName = "Student"
        };

        employee.SayName();
    }
}
