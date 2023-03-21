using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8.Task1
{
    public class Product : BaseProduct
    {
        public Product(string name, double price, TimeSpan expirationTime, DateTime dateOfManufacture) {
            Name = name;
            Price = price;
            ExpirationTime = expirationTime;
            DateOfManufacture = dateOfManufacture;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public TimeSpan ExpirationTime { get; set; }
        public DateTime DateOfManufacture { get; set; }

        public override void PrintInformation()
        {
            Console.WriteLine($"Название: {Name};Цена: {Price};Срок годности: {ExpirationTime.ToString("dd")};Дата производства: {DateOfManufacture.ToShortDateString()}");
        }
        public override void CheckExpirationDate()
        {
            if (DateTime.Now > DateOfManufacture + ExpirationTime)
                Console.WriteLine("Срок годности вышел\n");

            else Console.WriteLine("Товар соответствует сроку годности\n");
        }
    }
}
