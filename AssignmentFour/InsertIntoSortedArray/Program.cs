namespace InsertIntoSortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Original sorted array
            int[] elements = { 5, 10, 15, 20, 25, 30 };

            // Read new element from user
            Console.WriteLine("Enter the element to add to the array:");
            int newElement = Convert.ToInt32(Console.ReadLine());

            // Create new array with one extra space
            int[] newArray = new int[elements.Length + 1];

            int index = 0;
            bool inserted = false;

            // Insert elements while maintaining sorted order
            for (int i = 0; i < elements.Length; i++)
            {
                // Insert new element at the correct position
                if (!inserted && newElement < elements[i])
                {
                    newArray[index] = newElement;
                    index++;
                    inserted = true;
                }

                // Copy existing element
                newArray[index] = elements[i];
                index++;
            }

            // If new element is greater than all elements, insert at end
            if (!inserted)
            {
                newArray[index] = newElement;
            }

            // Display updated array
            Console.WriteLine("Array after insertion:");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(newArray[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
