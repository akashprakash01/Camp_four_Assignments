using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignmentOne.Model
{
    public class Person
    {
        //instance variables for data Hiding
        private string name;
        private int age;

        //default constructor
        public Person()
        {
        }


        //parametrized constructor
        public Person(string _name, int _age)
        {
            Name = _name;
            Age = _age;
        }


        //getter and setter
        //public property with controlled access (Encapsulation)
        protected string Name
            { 
            get { return name; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                    Console.WriteLine("Name should not be Empty or null");
                else
                    name = value;
            }
        }

        protected int Age
        {
            get { return age; }
            set {
                if (value < 5 || value > 50)
                    Console.WriteLine("Age should be in between 5 and 50");
                else
                    age = value;
            }

        }
            public void ReadData()
        {
            Console.Write("Enter Name: ");
            this.Name = Console.ReadLine();

            Console.Write("Enter age: ");
            this.Age = Convert.ToInt32(Console.ReadLine());
        }

        //method to display name and age but using virtual keyword this method is overrides
        public virtual void DisplayData()
        {
            Console.Write($"Name: {Name}  Age: {Age}");
        }

        
    }
}
