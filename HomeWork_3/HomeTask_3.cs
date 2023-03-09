using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;


namespace HomeWork_3
{
    internal class HomeTask_3
    {
        //<summary>
        //Создайте массив целых чисел.
        //Напишете программу, которая выводит сообщение о том,
        //входит ли заданное число в массив или нет. Пусть число для поиска задается с консоли.
        //</summary>
        public static void Task1()
        {
            int[] array = new int[] { 2, 6, 8, 10, 25, 77, 5, 42, 55, 99 };// создаем массив
            Console.Write("Введите число: ");//вводим число в строку
            int number = Int32.Parse(Console.ReadLine());// преобразуем строку
            bool b = false; // создаем булевую переменную
            for (int i = 0; i < array.Length; i++) //проходим цикл по каждому элементу массива
            {
                if (array[i] == number) // сравниваем элемент массива с введеным числом, если элемент массива совподает с введеным число  выводи
                {
                    b = true;// совпадение найдено
                    break; // выходим из цикла
                }
            }
            if (b != true) // совпадения не найдены, уведомляем
                Console.WriteLine("Число " + number + " не найдено в массиве!");
            else
                Console.WriteLine("Число " + number + " найдено в массиве!");
            
        }

        //Создайте массив целых чисел.Удалите все вхождения заданного числа из массива.
        //Пусть число задается с консоли.Если такого числа нет - выведите сообщения об этом.
        //В результате должен быть новый массив без указанного числа.
        public static void Task2() 
        {
            int[] array = { 1, 2, 1, 3, 3, 3, 4, 5, 2, 5, 11, 9, 11, 9, 1, 4, 6, 7, 6, 1, 2 };//создаем массив

            Console.Write("\nВведите число для удаления его из массива: ");// выводим сообщение
            int number = int.Parse(Console.ReadLine());// считываем введеное число и преобразуем его
            int newArrayLength = array.Length;// создаем переменную для хранения нового массива
            for (int i = 0; i < array.Length; i++) //проходим цикл по каждому элементу массива для определения нового массива
            {
                if (array[i] == number) // сравниваем элемент массива с введеным числом
                    newArrayLength--; //уменьшаем размер массива
            }
            if (newArrayLength == array.Length) //сравниваем длину нового массива с исходным, если длина равна, то не найдены совподения
            {

                Console.WriteLine("Число " + number + " не найдено в массиве!!!");
            }
            else
            {

                int[] newArray = new int[newArrayLength];  // создаем новый массив
                int j = 0;  //  создаем второй счетчик

                for (int i = 0; i < array.Length; i++)  // проходимся циклом по каждому элементу старого массива 
                {
                    if (array[i] != number)  // если наткнемся на элемент, который не нужно удалять, то запишем его в новый массив
                        newArray[j++] = array[i];  // в случае совпадений переходим не следующий элемент
                                                   // иначе просто пропускаем символ, который необходимо удалить
                }
                    Console.WriteLine("Массив до удаления введенного числа");
                
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine("\nМассив после удаления введенного числа");
                for (int i = 0; i < newArray.Length; i++)
                {
                    Console.Write(newArray[i] + " ");

                }

            }
        }

        //<summary>
        //Создайте и заполните массив случайным числами и выведете максимальное, минимальное и среднее значение.
        //Для генерации случайного числа используйте метод Random()
        //Пусть будет возможность создавать массив произвольного размера.Пусть размер массива вводится с консоли.
        //</summary>
        public static void Task3()
        {
            Console.Write("\n\nВведите количество элементов массива: ");// выводим сообщение
            int number = int.Parse(Console.ReadLine()); // считываем введеное число и преобразуем его
            Random random = new Random();// объявление переменной для генерации чисел
            int[] myArray = new int[number];//создаем массив
            
            Console.WriteLine("Вывод массива: ");//выводим сообщение

            for (int i = 0; i < myArray.Length; i++) //проходим цикл по каждому элементу массива
            {
                myArray[i] = random.Next();//присваеваем элементу массива случайное значение
                Console.WriteLine(myArray[i]);//выводим массив элементов
            }
            Console.Write("Max number: ");
            {
                Console.WriteLine(myArray.Max());
            }
            Console.Write("Min number: ");
            {
                Console.WriteLine(myArray.Min());
            }

            Console.Write("Average number: ");
            {
                Console.WriteLine(myArray.Average());
            }
            Console.ReadLine();
        }
        //<summary>
        //Создайте 2 массива из 5 чисел.
        //Выведите массивы на консоль в двух отдельных строках.
        //Посчитайте среднее арифметическое элементов каждого массива и сообщите, 
        //для какого из массивов это значение оказалось больше 
        //(либо сообщите, что их средние арифметические равны).
        //</summary>
        public static void Task4()
        {
            int[] a = new int[5];
            int[] b = new int[5];
            Random random = new Random();
            int firstAverageValue = 0;
            int secondAverageValue = 0;

            Console.WriteLine("\nЭлементы первого массива: ");
            for (int i = 0; i < 5; i++)
            {
                a[i] = random.Next(1, 20);
                Console.Write(a[i] + " ");
                firstAverageValue += a[i];
            }
            Console.WriteLine("\nЭлементы второго массива: ");
            for (int i = 0; i < 5; i++)
            {
                b[i] = random.Next(1, 20);
                Console.Write(b[i] + " ");
                secondAverageValue += b[i];
            }

            firstAverageValue /= a.Length;
            secondAverageValue /= b.Length;
            Console.WriteLine("\n\nСреднее значение первого массива: " + firstAverageValue);
            Console.WriteLine("\nСреднее значение второго массива: " + secondAverageValue);

            if (firstAverageValue > secondAverageValue)
                Console.WriteLine("\nСреднее значение элементов первого массива больше, чем у второго.");
            else if (firstAverageValue < secondAverageValue)
                Console.WriteLine("\nСреднее значение элементов второго массива больше, чем у первого.");
            else
                Console.WriteLine("\nСредние значения элементов обоих массивов равны.");
        }
    }
}
