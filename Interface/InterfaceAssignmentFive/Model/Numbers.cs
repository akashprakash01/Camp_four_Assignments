using InterfaceAssignmentFive.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignmentFive.Model
{
    public class Numbers : Ifirst, Isecond
    {
        void Ifirst.Display()
        {
            Console.WriteLine("Invoking method from Ifirst Interface");
        }
        void Isecond.Display()
        {
            Console.WriteLine("Invoking method from Isecond Interface");
        }
        public void GetValue()
        {
            Console.WriteLine("Enter a value");
            string value = Console.ReadLine();
            Console.WriteLine(value);
        }
        public void Demo()
        {
            Console.WriteLine("Method from the Isecond Inrterface");
        }
    }
}
