using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarage.Library
{
    public enum VehicleType
    {
        Car,
        Motorbike,
        Van
    }

    public class Vehicle
    {
        public VehicleType Type { get; }
        public string Registration { get; }
        public Size Size { get; }

        public Vehicle(VehicleType type, string registration, Size size)
        {
            Type = type;
            Registration = registration;
            Size = size;
        }
    }
}
