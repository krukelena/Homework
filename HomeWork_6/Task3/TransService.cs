using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6.Task3
{
    internal static class TransService
    {
        public static void PrintTransportType(Transport transport) =>
        Console.WriteLine($"Тип транспорта: {transport.GetTransportType()}");

        public static void Sort(Transport[] transports)
        {
            Transport temp;
            bool isSwap = true;
            while (isSwap)
            {
                isSwap = false;
                for (int j = 0; j < transports.Length - 1; j++)
                {
                    if (transports[j].NumberOfSeats > transports[j + 1].NumberOfSeats)
                    {
                        temp = transports[j];
                        transports[j] = transports[j + 1];
                        transports[j + 1] = temp;
                        isSwap = true;
                    }
                }
            }
        }
    }
}
