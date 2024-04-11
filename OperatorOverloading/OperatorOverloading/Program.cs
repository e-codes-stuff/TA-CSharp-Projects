class Program
{
    static void Main(string[] args)
    {
        // Instantiate 3 employees, two of which have the same Id value
        Employee employee1 = new Employee() { Id = 1, FirstName = "John", LastName = "Doe" };
        Employee employee2 = new Employee() { Id = 2, FirstName = "Jane", LastName = "Doe" };
        Employee employee3 = new Employee() { Id = 1, FirstName = "John", LastName = "Smith" };

        // The == implementation will check the Id only, meaning employee 1 == 3
        Console.WriteLine($"Employee 1 == Employee 2: {employee1 == employee2}");
        Console.WriteLine($"Employee 1 == Employee 3: {employee1 == employee3}");
    }
}
