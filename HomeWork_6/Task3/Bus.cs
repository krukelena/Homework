using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6.Task3
{
    internal class Bus : RoadTransport
    {
        public Bus(string destination, string number, string departureTime, int numberOfSeats) : base(destination, number, departureTime, numberOfSeats) { }

    }
}
