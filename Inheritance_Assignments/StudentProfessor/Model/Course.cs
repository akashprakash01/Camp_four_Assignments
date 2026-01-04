using System;
using System.Collections.Generic;
using System.Text;

namespace StudentProfessor.Model
{
    public class Course
    {
        private string courseName;
        private int duration;

        public string CourseName
        {
            get { return courseName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Course Name Must Filled");
                }
                else
                {
                    courseName = value;
                }
            }
        }
        public int Duration
        {
            get { return duration; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Enter Valid Duration");
                }
                else
                {
                    duration = value;
                }
            }
        }
        public void ReadCourse()
        {
            Console.Write("Enter a Course Name: ");
            this.CourseName = Console.ReadLine();
            Console.Write("Enter Coures Duration in Months: ");
            this.Duration = int.Parse(Console.ReadLine());
        }
        public void DisplayCourse()
        {
            Console.WriteLine($"Course Name: {CourseName}\nDuration: {Duration} Months");

        }


    }
}
