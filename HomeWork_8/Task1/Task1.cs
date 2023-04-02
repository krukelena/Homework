using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8.Task1
{
    //internal class 
    //{   /*Задание 1
    //  Полную структуру классов и их взаимосвязь продумать самостоятельно.
    //  Исходные данные база (List) из n товаров задать непосредственно в коде (захардкодить).
    //  Создать базовый класс Product с методами, позволяющим вывести на экран информацию о товаре, 
    //  а также определить, соответствует ли она сроку годности на текущую дату.

    //  Создать производные классы:
    //  Продукт (название, цена, дата производства, срок годности),
    //  Партия (название, цена, количество шт, дата производства, срок годности), 
    //  Комплект (названия, цена, перечень продуктов) со своими методами вывода информации на экран,
    //  и определения соответствия сроку годности.

    //  Создать базу (List) из n товаров, 
    //  вывести полную информацию из базы на экран, 
    //  а также организовать поиск просроченного товара (на момент текущей даты).
    //  Submission status*/

    //    /*Задание 1.1
    //    а) Создать List, содержащий объекты класса Product 
    //    б) Распечатать его содержимое используя foreach. 
    //    в) Изменить цену одного продукта на 100. 
    //    г) Удалить последний продукт. 
    //    д) Распечатать его содержимое
    //    ж) Удалить все продукты.*/

    public static class HomeWork_8
    {
        public static void ExecuteTask1()
        {
            List<BaseProduct> products = new List<BaseProduct>();
            products.Add(new Product("milk", 2.30, TimeSpan.FromDays(5), new DateTime(2023, 03, 19)));
            products.Add(new Product("milk", 2.50, TimeSpan.FromDays(5), new DateTime(2023, 03, 10)));
            products.Add(new Parties("juice", 10.5, TimeSpan.FromDays(30), new DateTime(2023, 03, 19), 50));
            products.Add(new Parties("juice", 25.78, TimeSpan.FromDays(10), new DateTime(2023, 03, 01), 60));
            products.Add(new Set("fruits", 65, new List<string> { "banana", "orange", "apple" }));

            foreach (var product in products)
            {
                product.PrintInformation();
                product.CheckExpirationDate();
            }

            ((Product)products[0]).Price = 100;
            products.RemoveAt(products.Count - 1);

            foreach (var product in products)
            {
                product.PrintInformation();
            }
            products.Clear();

        }

        //    /*Задание 1.2:
        //    Создать коллекцию, содержащую объекты Product. Написать метод, который перебирает элементы коллекции и проверяет цену продуктов.
        //    Если цена продукта больше 300 рублей, продукт перемещается в другую коллекцию.
        //    Необходимо вывести минимальное значение продукта из полученной коллекции.

        
        public static void ExecuteTask1_2()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("milk", 20, TimeSpan.FromDays(100), new DateTime(2023, 03, 19)));
            products.Add(new Product("meat", 300.30, TimeSpan.FromDays(5), new DateTime(2023, 03, 19)));
            products.Add(new Product("fish", 319.30, TimeSpan.FromDays(5), new DateTime(2023, 03, 19)));
            products.Add(new Product("chocolate", 45.67, TimeSpan.FromDays(65), new DateTime(2023, 03, 19)));
            products.Add(new Product("juice", 299, TimeSpan.FromDays(5), new DateTime(2023, 03, 19)));
            products.Add(new Product("milk2", 56.7, TimeSpan.FromDays(5), new DateTime(2023, 03, 19)));

            List<Product> expensiveProducts = ExtractExpensiveProducts(products);
            foreach (var product in expensiveProducts)
            {
                product.PrintInformation();
            }
        }
        public static List<Product> ExtractExpensiveProducts(List<Product> products)
        {
            var expensiveProducts = new List<Product>();

            foreach (var product in products)
            {
                if (product.Price > 300)
                {
                    expensiveProducts.Add(product);
                }
            }
            return expensiveProducts;
        }

        //Задание 1.3:
        //    Создайте Dictionary, содержащий пары значений  - имя продукта и количестов единиц продукта (класс Product).

        //    Перебрать и распечатать пары значений в формате "Name = abc, Count = 5"
        //    Перебрать и распечатать набор из имен продуктов
        //    Перебрать и распечатать значения количества единиц продуктов.
        //    Для каждого перебора создать свой метод.*/
        public static void ExecuteTask1_3()
        {
            var products = new Dictionary<string, int>()
            {
                {"Milk", 5 },
                {"Juice", 10},
                {"Bread", 30},
                {"Banana", 50}
            };

            PrintKeyValue(products);
            PrintKeys(products);
            PrintValues(products);
        }

        private static void PrintKeyValue(Dictionary<string, int> dictionary)
        {
            foreach (var element in dictionary)
            {
                Console.WriteLine($"Name = {element.Key}, Count = {element.Value}");
            }
        }

        private static void PrintKeys(Dictionary<string, int> dictionary)
        {
            foreach(var name in dictionary.Keys)
            {
                Console.WriteLine(name);
            }
        }

        private static void PrintValues(Dictionary<string, int> dictionary)
        {
            foreach(var count in dictionary.Values)
            {
                Console.WriteLine(count);
            }
        }
    }
}
