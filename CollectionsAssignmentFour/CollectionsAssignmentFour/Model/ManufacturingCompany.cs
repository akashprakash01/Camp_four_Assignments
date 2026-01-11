using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAssignmentFour.Model
{
    public class ManufacturingCompany
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        public void DisplayCompany()
        {
            Console.WriteLine($"Company: {Name}");
            Console.WriteLine($"Country: {Country}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Phone: {Phone}, Fax: {Fax}");
        }
    }
}
