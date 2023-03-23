using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    internal abstract class Triangle : Figure
    {
        // Создать класс для подсчета площади треугольников
        //- реализовать классы для равнобедренного, равностороннего, прямоугольного и разностороннего треугольника
        //- для каждого использовать свою формулу для подсчета площади
        //- площадь разностороннего треугольника считаем по формуле герона
        //- Создать отдельный класс который будет отвечать за логину создания треугольников.В нем вернуть нужный обьект треугольника проверив его стороны
        // - добавить класс квадрат и прямоугольник и логику подсчета площади для него
        // - добавить класс для реализации иерархии фигур
        // - создавь массив квадратов, прямоугольник и треугольников и вывести их площади
        protected int FirstSide;
        protected int SecondSide;
        protected int ThirdSide;
        public Triangle() : this(0, 0, 0) //создаем без параметров
        {

        }
        public Triangle(int firstSide, int secondSide, int thirdSide) //создаем конструктор
        {
            FirstSide = firstSide; // инициализируем поля
            SecondSide = secondSide;
            ThirdSide = thirdSide;
            CalculateArea();

        }
        protected override void CalculateArea()
        {
             
        }
        
    }
}
