using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarage.Library
{
    public struct Size
    {
        public float Height, Length, Width;

        public Size(float height, float length, float width)
        {
            Height = height;
            Length = length;
            Width = width;
        }

        public bool SmallerThanOrEqualTo(Size other)
        {
            return (Height <= other.Height && Length <= other.Length && Width <= other.Width);
        }
    }
}
