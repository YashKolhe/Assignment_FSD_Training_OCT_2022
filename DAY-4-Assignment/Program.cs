using DAY_4_Assignment;

internal class Program
{
    private static void Main(string[] args)
    {
        IUserPermission student = UserFactory.CreateUser("Student");
        LibraryServices studentService = new LibraryServices(student);
        studentService.PerformBorrowBook(1);
        studentService.PerformReserveBook(1);
        IUserPermission teacher = UserFactory.CreateUser("Teacher");
        LibraryServices teacherService = new LibraryServices(teacher);
        teacherService.PerformBorrowBook(1);
        teacherService.PerformReserveBook(1);
        Console.ReadLine();
    }
}