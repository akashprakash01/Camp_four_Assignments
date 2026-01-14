namespace BankingApplication.Model
{
    // Represents a single bank account in the banking system
    public class BankAccount
    {
        // Public property to store the account number
        public string AccountNumber { get; set; }

        // Public property to store the current balance of the account
        public int Balance { get; set; }

        // Parameterized constructor
        public BankAccount(string accNo)
        {
            AccountNumber = accNo; 
            Balance = 0;           
        }
    }
}
