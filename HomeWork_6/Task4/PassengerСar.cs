using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6.Task4;
   internal class PassengerCar : Auto { 
    
        public PassengerCar(string marka, string number, int speed, int loadCapacity) :
            base(marka, number, speed)
        {
            LoadCapacity = loadCapacity;
        }

        public override void PrintInformation()
        {
            Console.WriteLine("Легковой автомобиль: ");
            base.PrintInformation();
            Console.WriteLine();
        }
    }

