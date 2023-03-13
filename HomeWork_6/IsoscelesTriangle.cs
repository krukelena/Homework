using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    internal class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(int firstSide, int secondSide) : base(firstSide, secondSide, firstSide) { }

        protected override void CalculateArea()
        {
           Area = SecondSide * Math.Sqrt(FirstSide * FirstSide - SecondSide * SecondSide /4)/2;
        }
    }
}
