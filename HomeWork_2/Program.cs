using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace HomeWork_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
        }

        //Напишите программу - консольный калькулятор.
        //Создайте две переменные с именами operand1 и operand2.
        //Задайте переменным некоторые произвольные значения.
        //Предложите пользователю ввести знак арифметической операции.
        //Примите значение, введенное пользователем, и поместите его в строковую переменную sign.
        //Для организации выбора алгоритма вычислительного процесса, используйте переключатель switch.
        //Выведите на экран результат выполнения арифметической операции.
        //**В случае использования операции деления, организуйте проверку попытки деления на ноль.
        //И если таковая имеется, то отмените выполнение арифметической операции и уведомите об ошибке пользователя.
        static void Task1()
        {
            Console.Write("Введите первое число: ");
            decimal operand1 = decimal.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            decimal operand2 = decimal.Parse(Console.ReadLine());

            Console.Write("Введите знак арифметической операции число: ");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    Console.WriteLine(operand1 + operand2);
                    break;

                case "-":
                    Console.WriteLine(operand1 - operand2);
                    break;
                case "*":
                    Console.WriteLine(operand1 * operand2);
                    break;
                case "/":
                    if (operand2 == 0)
                        Console.WriteLine("Делить на 0 нельзя");
                    else
                        Console.WriteLine(operand1 / operand2);
                    break;
                default:
                    Console.WriteLine("Неизвестное математическое действие");
                    break;

            }
        }
        static void Task2()
        {
            // Напишите программу определения, попадает ли указанное пользователем
            // число от 0 до 100 в числовой промежуток[0 - 14][15 - 35][36 - 49][50 - 100].
            //Если да, то укажите, в какой именно промежуток.
            //Если пользователь указывает число, не входящее ни в один из имеющихся числовых промежутков,
            //то выводится соответствующее сообщение.
            Console.Write("Введите число от 0 до 100: ");

            double number = Convert.ToDouble(Console.ReadLine());

            if ((number >= 0) && (number <= 14))
            {
                Console.WriteLine($"Число от 0 до 14"); ;
            }
            else if ((number >= 15) && (number <= 35))
            {
                Console.WriteLine($"Число от 15 до 35");
            }
            else if ((number >= 36) && (number <= 49))
            {
                Console.WriteLine($"Число от 36 до 49");
            }
            else if ((number >= 50) && (number <= 100))
            {
                Console.WriteLine($"Число от 50 до 100");
            }
            else
            {
                Console.WriteLine($"Не соответсвует числовым промежуткам");
            }
        }
        static void Task3()
        {
            //Напишите программу, которая будет выполнять проверку чисел на четность.
            //Предложите два варианта решения поставленной задачи.

            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Число четное.");
            }
            else
            {
                Console.WriteLine("Число нечетное.");
            }

            //int a = 0;
            //Console.Write("Введите число: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //a = (number % 2);

            //if ( a == 0)
            //{
            //    Console.WriteLine("Число четное.");
            //}
            //else
            //{
            //    Console.WriteLine("Число нечетное.");
            //}
        }


    }
}

