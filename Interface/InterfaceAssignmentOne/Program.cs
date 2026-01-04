using InterfaceAssignmentOne.Interface;
using InterfaceAssignmentOne.Model;

namespace InterfaceAssignmentOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMammals mammal = new Animal();

            Console.WriteLine("Enter animal name:");
            string name = Console.ReadLine();

            int temp = mammal.GetBodyTemp(name);
            Console.WriteLine($"Body temperature of {name} is {temp}");

            Console.ReadKey();
        }
    }
}
