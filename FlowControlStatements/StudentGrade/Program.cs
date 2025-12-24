namespace StudentGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get input from user, roll no, name, marks in 3 subjects
            Console.WriteLine("Enter Your Roll Number: ");
            int rollNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Your Name: ");
            string studentName = Console.ReadLine();

            Console.WriteLine("Enter Marks for Subject 1: ");
            int subject1Marks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Marks for Subject 2: ");
            int subject2Marks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Marks for Subject 3: ");
            int subject3Marks = Convert.ToInt32(Console.ReadLine());

            // calculate total marks and percentage
            float totalMarks = subject1Marks + subject2Marks + subject3Marks;
            float percentage = (totalMarks / 300) * 100;

            Console.WriteLine($"Total marks for {studentName} is {totalMarks} and total percentage is {percentage}%");

            // determine grade based on percentage
            if (percentage > 90)
            {
                Console.WriteLine("Grade A+");
            }
            else if (percentage <= 90 && percentage > 80)
            {
                Console.WriteLine("Grade A");
            }
            else if (percentage <= 80 && percentage > 70)
            {
                Console.WriteLine("Grade B+");
            }
            else if (percentage <= 70 && percentage > 60)
            {
                Console.WriteLine("Grade B");
            }
            else if (percentage <= 60 && percentage > 50)
            {
                Console.WriteLine("Grade C");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
