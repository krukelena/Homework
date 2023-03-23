using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    internal abstract class Figure
    {
        public double Area { get; protected set; }

        protected abstract void CalculateArea();

    }

}
