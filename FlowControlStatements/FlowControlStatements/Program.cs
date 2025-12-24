namespace FlowControlStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            //try-catch
            //byte.parse(),byte.TryParse(100, out result)
            //true result 0-255-break
            //false null
            byte age = 0;
            Console.WriteLine("========Voter Eligibility Checker===========");
            Console.WriteLine("Minimum voting age is 18 years");
            Console.WriteLine("-----------------------------------");

            //keep asking until valid byte input is recieved
            while (true)
            {
                Console.Write("Enter your age(0-255): ");
                string input = Console.ReadLine();
                //Try to parse the input as byte
                if (byte.TryParse(input, out age))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid! Please enter a number b/w 0 and 255");
                }
            }

            if (age >= 18)
            {
                Console.WriteLine($"Age: {age}");
                Console.WriteLine("Congratulations!You are eligible to cast your vote");
            }
            else
            {
                Console.WriteLine($"Sorry,you are not eligible to vote yet");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
