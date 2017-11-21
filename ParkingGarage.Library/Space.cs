using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarage.Library
{
    public class Space
    {
        public string Id { get; }
        public Size Size { get; }
        public bool IsOccupied { get { return (_occupyingVehicle != null); } }
        
        private Vehicle _occupyingVehicle;

        public Space(string id, Size size)
        {
            Id = id;
            Size = size;
        }

        public bool ParkVehicle(Vehicle vehicle)
        {
            if (!IsOccupied && vehicle.Size.SmallerThanOrEqualTo(Size))
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
