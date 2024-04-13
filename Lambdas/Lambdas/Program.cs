class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
            new Employee { Id = 2, FirstName = "Jane", LastName = "Doe" },
            new Employee { Id = 3, FirstName = "John", LastName = "Doe" },
            new Employee { Id = 4, FirstName = "Joe", LastName = "Bloggs" },
            new Employee { Id = 5, FirstName = "Mary", LastName = "Jones" },
            new Employee { Id = 6, FirstName = "Mike", LastName = "Harris" },
            new Employee { Id = 7, FirstName = "Sue", LastName = "Brown" },
            new Employee { Id = 8, FirstName = "Chris", LastName = "Wilson" },
            new Employee { Id = 9, FirstName = "Pat", LastName = "Smith" },
            new Employee { Id = 10, FirstName = "Jamie", LastName = "Oliver" }
        };

        // Using a foreach loop to find employees named Joe
        List<Employee> joes = new List<Employee>();
        foreach (var employee in employees)
        {
            if (employee.FirstName == "Joe")
            {
                joes.Add(employee);
            }
        }

        // Using a lambda expression to find employees named Joe
        List<Employee> joesLambda = employees.Where(e => e.FirstName == "Joe").ToList();

        // Using a lambda expression to find employees with Id greater than 5
        List<Employee> idGreaterThanFive = employees.Where(e => e.Id > 5).ToList();

        Console.WriteLine("Employees named Joe (foreach loop):");
        foreach (var joe in joes)
        {
            Console.WriteLine($"{joe.Id}: {joe.FirstName} {joe.LastName}");
        }

        Console.WriteLine("\nEmployees named Joe (lambda expression):");
        foreach (var joe in joesLambda)
        {
            Console.WriteLine($"{joe.Id}: {joe.FirstName} {joe.LastName}");
        }

        Console.WriteLine("\nEmployees with Id greater than 5 (lambda expression):");
        foreach (var employee in idGreaterThanFive)
        {
            Console.WriteLine($"{employee.Id}: {employee.FirstName} {employee.LastName}");
        }
    }
}
