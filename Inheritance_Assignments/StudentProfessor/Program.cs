using StudentProfessor.Model;

namespace StudentProfessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Management");
            Student student = new Student();
            student.ReadData();
            student.Display();
            Console.WriteLine("Professor Management");
            Professor professor = new Professor();
            professor.ReadData();
            professor.ReadCourse();
            Console.WriteLine("");
            professor.Display();
            Console.WriteLine("Course");
            professor.DisplayCourse();
            Console.ReadKey();
        }
    }
}
