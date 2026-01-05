using System.Collections.Generic; // Required for SortedList and KeyValuePair

namespace PhoneIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a SortedList to store phone index
            SortedList<int, string> phoneNumbers = new SortedList<int, string>();

            // Adding phone numbers with unique keys
            phoneNumbers.Add(1, "1233445432");
            phoneNumbers.Add(3, "5678997765");

            // Iterating through the SortedList and displaying phone numbers
            // Elements are retrieved in ascending order of keys
            foreach (KeyValuePair<int, string> numbers in phoneNumbers)
            {
                Console.WriteLine(numbers.Value);
            }

            
            // Difference between SortedList and Hashtable:
            // SortedList stores key-value pairs in sorted order based on keys.
            // Hashtable stores key-value pairs using hashing and does not maintain order.
            // SortedList is type-safe and ordered.
            // Hashtable is faster for large data but is not type-safe.
            

            Console.ReadKey(); // Holds the console window
        }
    }
}
