using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6.Task2
{
    internal class Therapist : Doctor
    {
        public override void Heal()
        {
            Console.WriteLine("Терапевт начал лечить...");
        }
    }
}