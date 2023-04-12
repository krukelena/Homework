using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_9
{
    public interface IArithmetic<T>
    {
        T Addition(T other);
        T Subtract(T other);
        T Multiply(T other);
        Single Sqrt();
    }
}