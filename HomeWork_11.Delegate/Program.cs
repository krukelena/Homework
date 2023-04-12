namespace HomeWork_11.Delegate
{
    internal class Program
    {
        /// <summary>
        /// Cоздать класс мониторинга средней цен на жилье, цена будет генерироваться с помощью класса рандом
        /// и выдавать случайное значение в определенном диапазоне.
        //Для того чтобы вывод цены был удобен пользователю в классе мониторинга создать поле делегат,
        //обьект которого будет создаваться в классе мониторинга.
        //Пользователь указывает метод для отображения цены в удобном ему формате путем передачи метода в конструктор класса мониторинга.
        //пример создания обьекта монитора.
        //PriceMonitor monitor = new PriceMonitor(ShowPrice);
        //public static void ShowPrice(int price)
        //{
        //    //your code
        //}
        /// </summary>
        /// <param name="args"></param>
        /// 
        
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int value = rnd.Next(100000, 200000);
            Console.WriteLine(value);
        }
    }

}


