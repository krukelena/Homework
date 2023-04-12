using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_9
{
    public class Point<T>
    {
        public Point(T x, T y)
        {
            _x = x;
            _y = y;
        }

        private T _x;
        private T _y;

        public T X
        {
            get { return _x; }
            set { _x = value; }
        }

        public T Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public override string? ToString() => $"X = {_x}; Y = {_y}";

        public void PrintCoordinate() => Console.WriteLine(ToString());

        public Single GetDistance(Point<T> point, Func<T, T, T> addition, Func<T, T, T> subtract, Func<T, T, T> multiply, Func<T, Single> sqrt)
        {
            return sqrt(
                addition(
                    multiply(
                        subtract(point.X, _x),
                        subtract(point.X, _x)
                    ),
                    multiply(
                        subtract(point.Y, _y),
                        subtract(point.Y, _y)
                    )
                )
            );
            //return (point.X.Subtract(_x).Multiply(point.X.Subtract(_x)).Addition(point.Y.Subtract(_y).Multiply(point.Y.Subtract(_y)))).Sqrt();
        }

    }
}
