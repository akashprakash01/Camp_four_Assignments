namespace AssignmentDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  hardcoded userid and password
            //storing valid userId and password
            int validUserId = 23;
            string validPassword = "Akash@123";
            #endregion

            #region Login Process
            //Login attempts
            sbyte attempts = 1;
            while (attempts<=3)
            {
                // getting user inputs
                Console.Write("Enter Your UserId: ");
                int userId = int.Parse(Console.ReadLine());
                Console.Write("Enter Your Password: ");
                string password = Console.ReadLine();

                // checking credentials
                if (userId == validUserId && password == validPassword)
                {
                    Console.WriteLine("Login Success");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Credentials");
                    attempts++;
                }
            }
            #endregion

            #region Login Attempts
            // checking whether  the user user has exceeded maximum attempts
            if (attempts>3)
            {
                Console.WriteLine("Maximum attempts reached");
            }
            #endregion
            Console.ReadKey();
        }
    }
}
