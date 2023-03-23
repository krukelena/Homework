using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    internal class RightTriangle : Triangle
    {
        public RightTriangle( int firstSide) : base () { }


        protected override void CalculateArea()
        {
            Area= 0.5 * FirstSide * SecondSide;
        }
    }
}
