namespace ElectricityBill
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Variable declarations
            int customerID;
            string customerName;
            int unitConsumed;
            double amount = 0;
            //getting customerID and validating the input
            while (true)
            {
                Console.Write("Enter customer ID: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out customerID))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid! Please enter a valid customer ID (numeric value).");
                }
            }

            // getting customerName and validating the input
            while (true)
            {
                Console.Write("Enter your name: ");
                customerName = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(customerName))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid! Name cannot be empty.");
                }
            }
            // getting unitConsumed and validating the input
            while (true)
            {
                Console.Write("Enter unit consumed: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out unitConsumed))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid! Please enter a valid unit consumed (numeric value).");
                }
            }

    


            //calculating bill amount based on unit consumed
            if (unitConsumed <= 199)
            {
                amount = unitConsumed * 1.20;
            }
            else if(unitConsumed>=200 && unitConsumed < 400)
            {
                amount = unitConsumed * 1.50;
            }
            else if (unitConsumed>=400  && unitConsumed < 600)
            {
                amount = unitConsumed * 1.80;
            }
            else
            {
                amount = unitConsumed * 2.00;
            }

            //final bill printout
            Console.WriteLine("--------Electricity Bill---------");
            Console.WriteLine($"Customer IDNO : {customerID}");
            Console.WriteLine($"Customer Name : {customerName}");
            Console.WriteLine($"Unit Consumed : {unitConsumed}");
            Console.WriteLine($"Total Electricity bill: {amount:F2}");

            Console.WriteLine("Enter any key to exit ...");
            Console.ReadKey();
        }
    }
}
