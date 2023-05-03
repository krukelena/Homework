using Homework_Delegat;
/// <summary>
///  Cоздать класс мониторинга средней цен на жилье, цена будет генерироваться 
///с помощью класса рандом и выдавать случайное значение в определенном диапазоне. 
///Для того чтобы вывод цены был удобен пользователю в классе мониторинга создать поле делегат,
///обьект которого будет создаваться в классе мониторинга.
///Пользователь указывает метод для отображения цены в удобном ему формате путем передачи метода в конструктор
///класса мониторинга.
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        PriceMonitor monitor = new PriceMonitor(50, 1000, ShowPrice);
        monitor.Show(monitor.Price);
    }

    public static void ShowPrice(int price)
    {
        Console.WriteLine("Price = " + price);
    }
}
