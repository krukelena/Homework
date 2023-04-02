using System;

namespace HomeWork_6.Task3;

internal class Program
{

    /* Автопарк
        - Создать класс, cо следующими свойствами: сlass Bus: Пункт назначения, Номер, Время отправления, Число мест
        Определить get, set методы для этих свойств.
        Создать класс с main методом, в котором будет объявлен объект класса Bus. Вывести все данные (значения полей) объекта в консоль. 

        - Определить иерархию классов в предметной области: Парк общественного траспорта. 
        Определить иерархию различных видов общественного транспорта (например, Trolleybus, Tramcar и т.д. на подобие класса Bus выше.) 
        Определить в суперклассе (например, сlass Transport) метод, возвращающий тип транспорта (Electric, Rail, и т.п.). 
        Переопределить этот метод в классах наследниках.

        - В классе с main методом создать массив объектов из различных видов транспорта.
        Провести сортировку транспорта по количеству мест и вывести данные объектов в консоль.
        Запросить у пользователя время отправления и/или пункт назначения. 
        Найти в массиве объект, соответствующий заданным параметрам, и вывести его данные в консоль. 
        Запросить у пользователя время отправления. 
        Вывести в консоль список транспорта, отправляющегося после заданного времени.
        
        - Выбрать метод в супеклассе (e.g. Transport), который нельзя будет переопределить в классах наследниках и запретить это переопределение.
        Создать класс TransportService. 
        Определить внутри класса TransportService метод printTransportType, который будет принимать объект типа Transport как параметр. 
        Внутри метода printTransportType необходимо вызвать другой метод, возвращающий тип транспорта и вывести эту информацию на консоль. 
        ** В main вызвать метод printTransportType несколько раз, передавая ему как параметр объекты классов наследников (Bus, Trolleybus и т.д.)*/
    public static void Main(string[] args)
    {
        Bus firstBus = new Bus("Минск", "1187", "17:00", 78);
        Console.WriteLine("Автобус: ");
        firstBus.PrintInformation();

        Transport[] transports = new Transport[3];

        transports[0] = firstBus;
        transports[1] = new Tramcar("91", "Гомель", "07:00", 20);
        transports[2] = new Trolleybus("14", "Витебск", "13:00", 40);

        TransService.Sort(transports);
        Console.WriteLine("Доступный транспорт в отсортированном виде: ");
        foreach (Transport transport in transports)
            transport.PrintInformation();

        Console.WriteLine("Введите пункт назначения: ");
        string? input = Console.ReadLine();
        if (input != null)
        {
            foreach (Transport transport in transports)
            {
                if (transport.Destination.Equals(input))
                {
                    Console.WriteLine("\nНайденный транспорт: ");
                    transport.PrintInformation();
                }
            }
        }
        else Console.WriteLine("\nОшибка ввода");

        Console.WriteLine("\nВведите время отправления(чч:мм): ");

        input = Console.ReadLine();
        if (input != null)
        {
            int time = Int32.Parse(input.Remove(2));
            Console.WriteLine("\nНайденный транспорт, отправляющийся после заданного времени: ");
            foreach (Transport transport in transports)
                if (Int32.Parse(transport.DepartureTime.Remove(2)) >= time)
                    transport.PrintInformation();
        }
        else Console.WriteLine("\nОшибка ввода");

    }
}
