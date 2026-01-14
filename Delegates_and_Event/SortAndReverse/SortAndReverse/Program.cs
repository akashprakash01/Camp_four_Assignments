using System;

namespace SortAndReverse
{
    // Delegate declaration
    public delegate int[] ArrayOperation(int[] nums);

    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating object of Program class
            Program program = new Program();

            // Asking user for array length
            Console.WriteLine("Enter the length of the Array");
            int arrayLength = Convert.ToInt32(Console.ReadLine());

            // Declaring array with userdefined size
            int[] arrayElements = new int[arrayLength];

            // Reading array elements from user
            for (int i = 0; i < arrayLength; i++)
            {
                while (true)
                {
                    try
                    {
                        // Reading each element
                        Console.Write($"Enter the {i} Element of the array: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        arrayElements[i] = num;
                        break; 
                    }
                    catch
                    {
                        // Handles invalid (non-integer) input
                        Console.WriteLine("Invalid input");
                    }
                }
            }

            // Infinite loop to keep showing menu
            while (true)
            {
                Console.WriteLine("------Select One Option------");
                Console.WriteLine("1.Sorting");
                Console.WriteLine("2.Reverse");
                Console.WriteLine("3.Exit");

                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();

                // Delegate reference
                ArrayOperation operation = null;

                // Selecting method based on user choice
                switch (choice)
                {
                    case "1":
                        // Assign Sorting method to delegate
                        operation = program.Sorting;
                        break;

                    case "2":
                        // Assign Reverse method to delegate
                        operation = program.Reverse;
                        break;

                    case "3":
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        continue;
                }

                // Invoking the delegate the method (Sorting or Reverse) is called dynamically
                int[] result = operation(arrayElements);

                // Displaying result array
                Console.WriteLine("Result:");
                foreach (int num in result)
                {
                    Console.Write($"{num}\t");
                }
                Console.WriteLine();
            }
        }

        // Method to sort the array in ascending order
        public int[] Sorting(int[] nums)
        {
            // Sorting logic using nested loops
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    // Swap if elements are in wrong order
                    if (nums[j] < nums[i])
                    {
                        int temp = nums[j];
                        nums[j] = nums[i];
                        nums[i] = temp;
                    }
                }
            }

            // Returning sorted array
            return nums;
        }

        // Method to reverse the array
        public int[] Reverse(int[] nums)
        {
            // Reversing logic using nested loops
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    // Swap to reverse order
                    if (nums[j] > nums[i])
                    {
                        int temp = nums[j];
                        nums[j] = nums[i];
                        nums[i] = temp;
                    }
                }
            }

            // Returning reversed array
            return nums;
        }
    }
}
