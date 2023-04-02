using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8.Task1
{
    public class Set : BaseProduct
    {
        public Set(string name, double price, List<string> productList)

        {
            Name = name;
            Price = price;
            ProductList = productList;
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public List<string> ProductList { get; set; }

        public override void PrintInformation()
        {
            Console.WriteLine($"Название: {Name}; Цена: {Price}; Перечень продукта: {ProductList}");
        }

        public override void CheckExpirationDate()
        {
            Console.WriteLine("Продукт без срока годности\n");
        }
    }
}
