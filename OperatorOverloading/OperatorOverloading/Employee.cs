class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public static bool operator ==(Employee e1, Employee e2)
    {
        return e1.Id == e2.Id;
    }
}