using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRegistration.Model
{
    public interface IRegistrationProcess
    {
        public void AddingNewVehicle(Vehicle vehicle);
        public void DisplayVehicle(string numberPlate);
    }
}
