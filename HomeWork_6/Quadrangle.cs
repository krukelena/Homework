using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    internal abstract class Quadrangle : Figure
    {
        public int FirstSide;
        public int SecondSide;
        public int ThirdSide;
        public int FourthSide;

        protected Quadrangle(int firstSide, int secondSide, int thirdSide, int fourthSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
            FourthSide = fourthSide;
            CalculateArea();
        }

    }
}
