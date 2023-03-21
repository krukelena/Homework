using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork_8.Task0
{
    public static class HomeWork_8
    {
        /* Задание 0:
        1. У вас есть следующая коллекция: 
        ArrayList list = new ArrayList();
        И в вашей программе вызвается следующий код:
        object s = list[18];
        Необходимо перехватить ошибку и вывести на экран с указанием типа этой ошибки.
        2. Необходимо создать коллекцию Dictionary, в которой будет находиться 10 различных пар объектов.
        Необходимо вывести содержимое коллекции на экран.*/

        public static void ExecuteTask0_1()
        {
            ArrayList list = new ArrayList();
            list.Add("qwer");
            list.Add(2);
            list.Add(3.23);
            list[0] = 5;
            try
            {
                object? s = list[18];
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception: \n" + exception.Message);
            }
        }
        public static void ExecuteTask0_2()
        {
            var numberBox = new Dictionary<int, string>()
            {
                { 1, "Elena"},
                { 2, "Ivan"},
                { 3, "Tanya"},
                { 4, "Polina"},
                { 5, "Sos"},
                { 6, "Peter"},
                {7, "Goga" },
                {8, "Slava" },
                {9,"Nikolai" },
                {10, "Katy" }
            };
            foreach (var person in numberBox)
            {
                Console.WriteLine($"key: {person.Key}, value: {person.Value}\n");
            }
        }
    }
}
