using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6.Task3
{
    internal abstract class Transport
    { 
        public string Destination { get; set; }
        public string Number { get; set; }
        public string DepartureTime { get; set; }
        public int NumberOfSeats { get; set; }
        protected Transport(string destination, string number, string departureTime, int numberOfSeats)
        {
            Destination = destination;
            Number = number;
            DepartureTime = departureTime;
            NumberOfSeats = numberOfSeats;
        }
        public abstract string GetTransportType();

        public void PrintInformation() => Console.WriteLine($"Пункт назначения: { Destination}\n" +
                              $"Номер транспорта: {Number}\n" +
                              $"Время отправления: {DepartureTime}\n" +
                              $"Число мест: {NumberOfSeats}\n");
    } 
}
