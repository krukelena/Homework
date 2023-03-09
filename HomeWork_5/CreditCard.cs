using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5
{
    public class CreditCard
    {
        // 2. Создать класс CreditCard c полями номер счета, текущая сумма на счету.
        //Добавьте метод, который позволяет начислять сумму на кредитную
        //карточку.
        //Добавьте метод, который позволяет снимать с карточки некоторую
        //сумму.
        //Добавьте метод, который выводит текущую информацию о карточке.
        //Напишите программу, которая создает три объекта класса CreditCard у
        //которых заданы номер счета и начальная сумма
        //Тестовый сценарий для проверки:
        //Положите деньги на первые две карточки и снимите с третьей.
        //Выведите на экран текущее состояние всех трех карточек.


        public string Number;
        public double Cash;

        public CreditCard(string number, double cash)
        {
            this.Number = number;
            this.Cash = cash;
        }

        public void ReplenishCash(double sum)
        {
            Cash += sum;
        }

        public void WithdrawCash(double sum)
        {
            Cash -= sum;
        }
        public void PrintCreditCard()
        {
            Console.WriteLine($"Номер счета: {Number} + Текущая сумма на карте: {Cash}");
        }
    }

}
