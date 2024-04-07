class Program
{
    static void Main(string[] args)
    {
        // Initialize Employee with Id field
        Employee employee = new Employee() { FirstName = "Sample", LastName = "Student", Id = 1 };
        employee.SayName();
    }
}
