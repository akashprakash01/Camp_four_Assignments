namespace ElementDeletion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayElements = { 23, 33, 22, 12, 54, 6, 7, 8, 99, 10 };

            // Display array elements with positions
            Console.WriteLine("Array elements:");
            for (int i = 0; i < arrayElements.Length; i++)
            {
                Console.WriteLine($"Value: {arrayElements[i]}  Position: {i}");
            }

            // Read position to delete
            Console.Write("\nEnter the position to delete: ");
            int delPosition = Convert.ToInt32(Console.ReadLine());


            // Create new array with reduced size
            int[] newArray = new int[arrayElements.Length - 1];
            int newIndex = 0;

            // Copy elements except the one at deletion position
            for (int i = 0; i < arrayElements.Length; i++)
            {
                if (i != delPosition)
                {
                    newArray[newIndex] = arrayElements[i];
                    newIndex++;
                }
            }

            // Display updated array
            Console.WriteLine("\nArray after deletion:");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(newArray[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
