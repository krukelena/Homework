using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    internal class Rectangle : Quadrangle
    {

        public Rectangle(int firstSide, int secondSide) : base(firstSide, secondSide, firstSide, secondSide) { }
        protected override void CalculateArea()
        {
            Area = FirstSide * SecondSide;
        }
    }
}
