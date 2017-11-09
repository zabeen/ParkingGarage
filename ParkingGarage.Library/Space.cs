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

        public bool ParkVehicle(Vehicle vehicle)
        {
            if (!IsOccupied && vehicle.Size.SmallerOrEqualThan(Size))
            {
                _occupyingVehicle = vehicle;
                return true;
            }

            return false;
        }

        public void Empty()
        {
            _occupyingVehicle = null;
        }
    }
}
