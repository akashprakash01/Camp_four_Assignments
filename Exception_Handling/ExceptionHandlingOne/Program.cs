namespace ExceptionHandlingOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------Organization---------");

            int id;
            string name;
            int age;
            int salary;

            // Employee ID
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter Employee ID: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Enter a valid Employee ID (integer).");
                }
            }

            // Employee Name
            while (true)
            {
                Console.WriteLine("Enter Employee Name: ");
                name = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(name))
                    break;

                Console.WriteLine("Name cannot be empty.");
            }

            // Employee Age
            while (true)
            {
                //try catch to check Age
                try
                {
                    Console.WriteLine("Enter Employee Age: ");
                    age = Convert.ToInt32(Console.ReadLine());

                    if (age >= 18 && age <= 60)
                        break;
                    else
                        Console.WriteLine("Age must be between 18 and 60.");
                }
                catch
                {
                    Console.WriteLine("Age must be an integer.");
                }
            }

            // Employee Salary
            while (true)
            {
                //try catch to check salary
                try
                {
                    Console.WriteLine("Enter Employee Salary: ");
                    salary = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Salary must be an integer.");
                }
            }

            // Output
            Console.WriteLine("----- Employee Details -----");
            Console.WriteLine($"Employee ID: {id}");
            Console.WriteLine($"Employee Name: {name}");
            Console.WriteLine($"Employee age: {age}");
            Console.WriteLine($"Employee salary: {salary}");

            Console.ReadKey();
        }
    }
}
