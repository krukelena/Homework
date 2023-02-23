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
                    {
                        Console.WriteLine(operand1 + operand2);
                        break;
                    }
                case "-":
                    {
                        Console.WriteLine(operand1 - operand2);
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine(operand1 * operand2);
                        break;
                    }
                case "/":
                    {
                        if (operand2 == 0)
                        {
                            Console.WriteLine("Делить на 0 нельзя");
                        }
                        else
                        {
                            Console.WriteLine(operand1 / operand2);
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Неизвестное математическое действие");
                        break;
                    }
            }
        }
    }
}

