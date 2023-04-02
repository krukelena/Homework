using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
   internal class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(int firstSide, int secondSide, int thirdSide) : base (firstSide, secondSide, thirdSide) { }

        protected override void CalculateArea()
        {
            Area = Math.Sqrt(3) * FirstSide * FirstSide / 4; 
        }
    }
}
