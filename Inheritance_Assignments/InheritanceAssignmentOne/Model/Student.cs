using System;

namespace InheritanceAssignmentOne.Model
{
    public class Student : Person
    {
        // instance variables (data hiding)
        private int rollNo;
        private int marks;
        private char grade;

        public Student()
        {
        }

        public int RollNo
        {
            get { return rollNo; }
            set { rollNo = value; }
        }

        public int Marks
        {
            get { return marks; }
            set
            {
                if (value < 0 || value > 100)
                    Console.WriteLine("Marks should be between 0 and 100");
                else
                    marks = value;
            }
        }

        // method to get data from user
        public void GetData()
        {
            Console.Write("Enter Your Roll No: ");
            RollNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Your Marks: ");
            Marks = Convert.ToInt32(Console.ReadLine());
        }

        // compute grade and store it
        public void ComputeGrade()
        {
            grade =
                Marks >= 90 ? 'A' :
                Marks >= 80 ? 'B' :
                Marks >= 70 ? 'C' :
                Marks >= 60 ? 'D' : 'F';
        }

        // overriding parent display method
        public override void DisplayData()
        {
            base.DisplayData();
            Console.WriteLine($" Roll: {RollNo}  Marks: {Marks}  Grade: {grade}");
        }
    }
}
