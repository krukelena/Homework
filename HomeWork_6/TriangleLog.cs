using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    internal static class TriangleLog
    {
        public static Figure CreateTriangle(int firstSide, int secondSide, int thirdSide)
        {
            if (firstSide == secondSide && secondSide == thirdSide)
              return new RightTriangle(firstSide);
            if (firstSide == secondSide || secondSide == thirdSide || thirdSide == firstSide)
                return new IsoscelesTriangle(firstSide, secondSide);
            if (firstSide * firstSide + secondSide * secondSide == thirdSide * thirdSide)
                return new EquilateralTriangle(firstSide, secondSide, thirdSide);
             return new ScaleneTriangle(firstSide, secondSide, thirdSide);
        }
    }
}
