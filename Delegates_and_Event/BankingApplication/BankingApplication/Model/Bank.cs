using System;
using System.Collections.Generic;
using BankingApplication.Model;

namespace BankingApplication.Services
{
    // Delegate representing a bank transaction
    public delegate void TransactionDelegate(string accNo);

    public class Bank
    {
        // Dictionary to store multiple bank accounts
        private Dictionary<string, BankAccount> accounts =new Dictionary<string, BankAccount>();

        // Create new bank account
        public void CreateAccount()
        {
            Console.Write("Enter Account Number: ");
            string accNo = Console.ReadLine();

            if (accounts.ContainsKey(accNo))
            {
                Console.WriteLine("Account already exists.");
                return;
            }

            accounts.Add(accNo, new BankAccount(accNo));
            Console.WriteLine("Account created successfully.");
        }

        // Validate account existence
        private bool IsValidAccount(string accNo)
        {
            if (!accounts.ContainsKey(accNo))
            {
                Console.WriteLine("Account not found.");
                return false;
            }
            return true;
        }

        // Read valid amount using while
        private int ReadValidAmount()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter amount: ");
                    int amount = Convert.ToInt32(Console.ReadLine());

                    if (amount <= 0)
                        throw new Exception("Amount must be greater than zero");

                    return amount;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Invalid input: {ex.Message}");
                }
            }
        }

        // Deposit transaction
        public void Deposit(string accNo)
        {
            if (!IsValidAccount(accNo)) return;

            int amount = ReadValidAmount();
            accounts[accNo].Balance += amount;

            Console.WriteLine($"Deposited {amount}. Balance: {accounts[accNo].Balance}");
        }

        // Withdraw transaction with validation
        public void Withdraw(string accNo)
        {
            if (!IsValidAccount(accNo)) return;

            int amount = ReadValidAmount();

            if (accounts[accNo].Balance < amount)
            {
                Console.WriteLine("Insufficient balance.");
                return;
            }

            accounts[accNo].Balance -= amount;
            Console.WriteLine($"Withdrawn {amount}. Balance: {accounts[accNo].Balance}");
        }

        // Check balance
        public void CheckBalance(string accNo)
        {
            if (!IsValidAccount(accNo)) return;

            Console.WriteLine($"Current Balance: {accounts[accNo].Balance}");
        }
    }
}
