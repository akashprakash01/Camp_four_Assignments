using System;
using BankingApplication.Services;

namespace BankingApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a single Bank object to manage all accounts and transactions
            Bank bank = new Bank();

            // Infinite loop to repeatedly show the menu until user chooses Exit
            while (true)
            {
                // Display banking menu
                Console.WriteLine("\n------- Banking System ---------");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Check Balance");
                Console.WriteLine("5. Exit");

                // Read user choice
                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();

                // Exit condition
                if (choice == "5")
                {
                    Console.WriteLine("Thank you for using the banking system.");
                    break; 
                }

                // Declare delegate reference
                // It will point to Deposit, Withdraw, or CheckBalance methods
                TransactionDelegate transaction = null;

                // Account number is required for all operations except Create Account
                if (choice != "1")
                {
                    // Read account number from user
                    Console.Write("Enter Account Number: ");
                    string accNo = Console.ReadLine();

                    // Select operation based on user choice
                    switch (choice)
                    {
                        case "2":
                            // Assign Deposit method to delegate
                            transaction = bank.Deposit;

                            // Invoke Deposit for the given account number
                            transaction.Invoke(accNo);
                            break;

                        case "3":
                            // Assign Withdraw method to delegate
                            transaction = bank.Withdraw;

                            // Invoke Withdraw for the given account number
                            transaction.Invoke(accNo);
                            break;

                        case "4":
                            // Assign CheckBalance method to delegate
                            transaction = bank.CheckBalance;

                            // Invoke CheckBalance for the given account number
                            transaction.Invoke(accNo);
                            break;

                        default:
                            // Handles invalid menu choices
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                else
                {
                    // Create a new bank account
                    bank.CreateAccount();
                }
            }

            Console.ReadKey();
        }
    }
}
