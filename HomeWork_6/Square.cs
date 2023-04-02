using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
   internal class Square : Rectangle
    {
        public Square(int firstSide) : base(firstSide, firstSide)
        {

            Area = FirstSide * FirstSide;

        }
    }
}
