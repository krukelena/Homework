using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Surgeon : Doctor
    {
        public override void Heal()
        {
            Console.WriteLine("Хирург начал лечить...");
        }
    }
}
