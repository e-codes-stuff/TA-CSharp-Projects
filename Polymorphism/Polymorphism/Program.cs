class Program
{
    static void Main(string[] args)
    {
        // Use polymorphism to create an object of type IQuittable
        IQuittable quittableEmployee = new Employee();
        
        // Call the Quit method on the IQuittable object
        quittableEmployee.Quit();
    }
}
