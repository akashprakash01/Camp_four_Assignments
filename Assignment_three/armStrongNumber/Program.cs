namespace armStrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //getting input from user
            Console.WriteLine("Enter a number to check if it is an Armstrong number:");
            int originalNumber = Convert.ToInt32(Console.ReadLine());

            int numberCopyOne = originalNumber;
            int numberCopytwo = originalNumber;
            int unitPlaces = 0;
            int sum = 0;


            //while loop to calculate the unit places
            while (numberCopyOne > 0)
            {
                unitPlaces++;
                numberCopyOne = (numberCopyOne / 10);

            }

            //while loop to iterate though each unit places
            while (numberCopytwo > 0)
            {
                int rem = numberCopytwo % 10;
                int power = 1;

                // for loop for multiplication and adding it to the sum
                for (int i = 1; i <= unitPlaces; i++)
                {

                    power *= rem;

                }
                sum += power;
                numberCopytwo = numberCopytwo / 10;


            }

            if (originalNumber == sum)
            {
                Console.WriteLine("This number is an ArmstrongNumber");
            }
            else
            {
                Console.WriteLine("This is not an ArmstrongNumber");
            }

            Console.ReadKey();

        }
    }
}
