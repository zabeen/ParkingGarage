using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarage.Library
{
    public class Space
    {
        public Size Size { get; }
        public bool IsOccupied { get { return (_occupyingVehicle != null); } }
        
        private Vehicle _occupyingVehicle;

        public Space(Size size)
        {
            Size = size;
        }

        public void ParkVehicle(Vehicle vehicle)
        {
            _occupyingVehicle = vehicle;
        }

        public void EmptyThisSpace()
        {
            _occupyingVehicle = null;
        }
    }
}
