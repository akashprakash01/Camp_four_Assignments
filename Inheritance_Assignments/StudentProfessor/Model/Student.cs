using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace StudentProfessor.Model
{
    public class Student 
    {
        private string name;
        private int studentId;
        private int major;
        public string major_name;


        public int StudentID
        {
            get { return studentId; }
            set
            {
                if (value > 0)
                {
                    studentId = value;
                }
                else
                {
                    Console.WriteLine("Enter Valid Student Id");
                }
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name Must to Filled");
                }
                else
                {
                    name = value;
                }
            }
        }
        public int Major
        {
            get { return major; }
            set {
                    switch (value)
                    {
                        case 1:
                        major_name = "Graduate";
                            break;
                        case 2:
                        major_name = "Post Graduate";
                            break;
                        default:
                            {
                                Console.WriteLine("Enter Valid choice");
                                break;
                            }
                    }
                    }
        }
        public void ReadData()
        {
            Console.Write("Enter Name: ");
            this.Name = Console.ReadLine();
            Console.Write("Enter StudentID ");
            this.StudentID=int.Parse(Console.ReadLine());
            Console.Write("1 For Graduate and 2 For Post Graduate ");
            this.Major = int.Parse(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine($"Name: {Name}\nStudentName {StudentID}\nMajor: {major_name}");
        }
    }

}
