using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceQuestionThree.Model
{
    public class Executive : Employee
    {


        // Overriding the BasicSalary property from the base class
        protected override int BasicSalary
        {
            get { return base.BasicSalary; }
            set
            {
                // Validating that Executive basic pay is greater than 10000
                if (value <= 10000)
                    Console.WriteLine("Basic Pay should be more than 10000");
                else
                    base.BasicSalary = value;
            }
        }

        }


}
