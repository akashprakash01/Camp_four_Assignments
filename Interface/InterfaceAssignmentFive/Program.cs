using InterfaceAssignmentFive.Interface;
using InterfaceAssignmentFive.Model;

namespace InterfaceAssignmentFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ifirst ObjectOne = new Numbers();
            Isecond ObjectTwo = new Numbers();
            ObjectOne.Display();
            ObjectTwo.Display();

            Console.ReadKey();
        }
    }
}
