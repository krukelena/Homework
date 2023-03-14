using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6.Task3
{
    internal abstract class RoadTransport : Transport
    {
        public RoadTransport(string destination, string number, string departureTime, int numberOfSeats) : base(destination, number, departureTime, numberOfSeats) { }

        public override string GetTransportType()
        {
            return "Дорожный транспорт";
        }
    }
}
