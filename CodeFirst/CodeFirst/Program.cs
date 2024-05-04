using (var ctx = new SchoolContext())
{
    var student = new Student() { StudentName = "Joe" };

    ctx.Students.Add(student);
    ctx.SaveChanges();

    Console.WriteLine("Added Joe to database!");
}