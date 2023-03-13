using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    internal class ScaleneTriangle : Triangle
    {    
        public ScaleneTriangle(int firstSide, int secondSide, int thirdSide) : base (firstSide, secondSide, thirdSide) { }

        protected override void CalculateArea()
        {
            double p = FirstSide + SecondSide+ThirdSide;
            Area = Math.Sqrt(p * (p - FirstSide) * (p - SecondSide) * (p - ThirdSide));
        }
    }
}
