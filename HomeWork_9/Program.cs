
//1.Напишите обобщенный класс, который может хранить в массиве объекты любого типа. 
//  Кроме того, данный класс должен иметь методы для добавления данных в массив, 
//  удаления из массива, получения элемента из массива по индексу и метод, возвращающий длину массива.

//2.Реализовать класс машина у который будет поле  обобщенное двигатель. 
//  Создать иерархию наследования для двигателей (абстрактный, дизельный, бензиновый, електро). 
//  Сделать так чтобы создать автомобиль можно было только передавая туда один из типов двигателя. 
//  Реализовать методы для движения автомобиля и заправки в зависимости от типа двигателя.


//3.Реализовать обобщенный класс Point , который определяет точку на координатной плоскости.
//В классе реализовать:обобщенные внутренние поля x, y;
//конструктор с 2 параметрами;
//свойства доступа к внутренним полям класса;
//метод, выводящий значения внутренних полей класса
//метод нахождения расстояния с другой точкой

using HomeWork_9;

public class Program
{
    public static void Main()
    {
        ExecuteTask1();
        ExecuteTask2();
        ExecuteTask3();
    }

    public static void ExecuteTask1()
    {
        var arr = new OwnArray<int>();
        arr.Add(1);
        arr.Add(3);
        arr.Add(7);
        arr.Add(9);
        arr.Add(11);
        arr.Remove();
        arr.Remove();

        Console.WriteLine(arr.GetValue(2));
        Console.WriteLine(arr.GetValue(4));
    }

    public static void ExecuteTask2()
    {
        Car<ElectroEngine> car = new Car<ElectroEngine>(new ElectroEngine());
        Car<DieselEngine> car1 = new Car<DieselEngine>(new DieselEngine());
        Car<PetrolEngine> car2 = new Car<PetrolEngine>(new PetrolEngine());
        car.Move();
        car1.Move();
        car2.Move();
        car.Refuel();
        car1.Refuel();
        car2.Refuel();
    }
    public static void ExecuteTask3()
    {
        Point<Int32> point1 = new Point<Int32>(4, 16);
        Point<Int32> point2 = new Point<Int32>(7, 20);

        Console.Write("The distance - ");
        Console.Write(
            point1.GetDistance(
                point2,
                (x, y) => x + y,
                (x, y) => x - y,
                (x, y) => x * y,
                (x) => (Single)Math.Sqrt(x)
            )
        );
    }
}

