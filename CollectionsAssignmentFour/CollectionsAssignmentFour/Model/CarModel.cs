using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAssignmentFour.Model
{
    public class CarModel
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"{Brand} {Model} ({Year})";
        }
    }
}
