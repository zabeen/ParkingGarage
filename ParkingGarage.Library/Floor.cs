using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarage.Library
{
    public class Floor
    {
        public int Level { get; }
        public List<Space> Spaces { get { return _spaces; } }

        private List<Space> _spaces;

        public Floor (int level, IEnumerable<Space> spaces)
        {
            Level = level;
            _spaces = spaces.ToList();
        }
    }
}
