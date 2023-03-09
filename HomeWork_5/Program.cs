using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace HomeWork_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
        }

        private static void Task1()
        {
            Phone phone1 = new Phone();
            Phone phone2 = new Phone();
            Phone phone3 = new Phone("+375444444444", "iPhone", 3.4);

            phone1.Weight = 1;
            phone1.Number = "+375333565116";
            phone1.Model = "POCO";
            phone2.Number = "+3752911111111";

            Console.WriteLine(phone1.Number + " " + phone1.Model + " " + phone1.Weight);
            Console.WriteLine(phone2.Number + " " + phone2.Model + " " + phone2.Weight);
            Console.WriteLine(phone3.Number + " " + phone3.Model + " " + phone3.Weight);

            phone1.ReceiveCall("Vladislav");
            phone2.ReceiveCall("Konstantin");
            phone3.ReceiveCall("Peter", "+375244444456");

            Console.WriteLine(phone1.GetNumber());
            Console.WriteLine(phone2.GetNumber());
            Console.WriteLine(phone3.GetNumber());

            phone1.SendMessage("firstNumber", "secondNumber", "thirdNumber", "4", "5");
        }

        private static void Task2()
        {
            CreditCard creditCard1 = new CreditCard("BY20 0202 0404 0505 0606", 150);
            CreditCard creditCard2 = new CreditCard("BY21 1202 3404 0505 0606", 2100);
            CreditCard creditCard3 = new CreditCard("BY20 2202 4404 0505 0606", 1597);

            creditCard1.ReplenishCash(220);
            creditCard2.ReplenishCash(500);
            creditCard3.WithdrawCash(1097);

            creditCard1.PrintCreditCard();
            creditCard2.PrintCreditCard();
            creditCard3.PrintCreditCard();
        }

        private static void Task3()
        {
            ATM atm = new ATM(20,10,32);
            atm.WithdrawCash(800);
            atm.WithdrawCash(550);
            atm.WithdrawCash(620);
        }
    }
}
