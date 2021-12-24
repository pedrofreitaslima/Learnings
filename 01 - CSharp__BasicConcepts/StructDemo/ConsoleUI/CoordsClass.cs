using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class CoordsClass : ICoords
    {
        public int Latitude, Longitude;
        public CoordsClass(int latitude, int longitude) => (Latitude, Longitude) = (latitude, longitude);
        public string View() { return String.Format("({0},{1})", this.Latitude, this.Longitude); }
    }
}
