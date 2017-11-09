using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarage.Library
{
    public class Garage
    {
        public List<Floor> Floors { get { return _floors; } }

        private List<Floor> _floors;

        public Garage(IEnumerable<Floor> floors)
        {
            _floors = floors.ToList();
        }
    }
}
