using System;

namespace InheritanceAssignmentOne.Model
{
    // employee class inheriting Person class
    public class Employee : Person
    {
        private double basicPay;
        private double houseRent;
        private double salary;

        //constructor
        public Employee()
        {
        }

        //property to access and assign basicpay 
        public double BasicPay
        {
            get { return basicPay; }
            set { basicPay = value; }
        }

        //property to access and assign houserent 
        public double HouseRent
        {
            get { return houseRent; }
            set { houseRent = value; }
        }

        //property to access and assign salary 
        public double Salary
        {
            get { return salary; }
            private set { salary = value; }
        }
        

        //method to get data from the user
        public void GetData()
        {
            Console.Write("Enter Basic Pay: ");
            BasicPay = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter House Rent: ");
            HouseRent = Convert.ToDouble(Console.ReadLine());
        }

        //method to calculate the salary
        public void ComputeSalary()
        {
            Salary = BasicPay + HouseRent;
        }


        //display employee details
        public override void DisplayData()
        {
            base.DisplayData();
            Console.WriteLine($" Basic Pay: {BasicPay}  House Rent: {HouseRent}  calculated salary: {Salary}");
        }
    }
}
