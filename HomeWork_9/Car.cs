using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_9
{   /// <summary>
    /// Реализовать класс машина у который будет поле  обобщенное двигатель. 
    /// Реализовать методы для движения автомобиля и заправки в зависимости от типа двигателя.
    /// </summary>
    public class Car<TEngine> where TEngine : Engine
    { 
        public Car(TEngine engineStyle)
        {
            EngineStyle = engineStyle;
        }

        public TEngine EngineStyle { get; private set; }

        public void Move()
        {
            String engineType = EngineStyle.GetEngineType();
            Console.WriteLine("Машина двигается с помощью " + engineType);
        }
        public void Refuel()
        {
            Console.WriteLine($"Заправка  \"{EngineStyle.GetEngineType()}\"");
        }

    }

}
