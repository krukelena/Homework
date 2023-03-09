using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5
{
    public class ATM
    {
        //.3. Создать класс, описывающий банкомат.
        //Набор купюр, находящихся в банкомате, должен задаваться тремя
        //свойствами:
        //количеством купюр номиналом 20, 50 и 100.
        //Сделать метод для добавления денег в банкомат.
        //Сделать метод, снимающуий деньги, который принимает сумму денег,
        //а возвращает булевое значение - успешность выполнения операции.
        //При снятии денег метод должен распечатывать каким количеством
        //купюр какого номинала выдаётся сумма.
        //Создать конструктор с тремя параметрами - количеством купюр каждого
        //номинала.

        public int TwentyDollarBillsCount;
        public int FiftyDollarBillsCount;
        public int HundredDollarBillsCount;
        public ATM(int twentyDollarBillsCount, int fiftyDollarBillsCount, int hundredDollarBillsCount)
        {
            TwentyDollarBillsCount = twentyDollarBillsCount;
            FiftyDollarBillsCount = fiftyDollarBillsCount;
            HundredDollarBillsCount = hundredDollarBillsCount;
        }

        public void AddMoney(int twentyDollarBillsCount, int fiftyDollarBillsCount, int hundredDollarBillsCount)
        {
            TwentyDollarBillsCount += twentyDollarBillsCount;
            FiftyDollarBillsCount += fiftyDollarBillsCount;
            HundredDollarBillsCount += hundredDollarBillsCount;

        }
        public bool WithdrawCash (int cash)
        {
            int twentyDollarBillsCount = 0;
            int fiftyDollarBillsCount = 0;
            int hundredDollarBillsCount = 0;

            while (cash > 0)
            {
                if (cash >= 100)
                {
                    cash -= 100;
                    hundredDollarBillsCount++;
                }
                else if (cash >= 50 && cash < 100)
                {
                    cash -= 50;
                    fiftyDollarBillsCount++;
                }
                else if (cash >= 20 && cash < 50)
                {
                    cash -= 20;
                    twentyDollarBillsCount++;
                }
                else break;
            }
            if (cash != 0) return false;

            if (twentyDollarBillsCount!= 0) Console.WriteLine($"Выдано {twentyDollarBillsCount} купюр наминалом 20");
            if (fiftyDollarBillsCount != 0) Console.WriteLine($"Выдано {fiftyDollarBillsCount} купюр наминалом 50");
            if (hundredDollarBillsCount != 0) Console.WriteLine($"Выдано {hundredDollarBillsCount} купюр наминалом 100");
            Console.WriteLine();
            return true;
        }
    }
}
