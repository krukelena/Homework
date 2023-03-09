using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HomeWork_3
{
    internal class HomeTask_4
    {
        ///// <summary>
        /////  Заменить в строке все вхождения 'test' на 'testing'. Удалить из текста все символы, являющиеся цифрами
        ///// </summary>
        public static void Task1()
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine(); // считываем  введенное значение и записываем в переменну.
            text = text.Replace("test", "testing");// заменим текст
            string output = "";
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    output += c;
                }
            }
            Console.WriteLine(output);
        }

        //<summary>
        //Используя метод вывода значения в консоль, выполните конкатенацию слов и выведите на экран следующую фразу:
        //Welcome to the TMS lesons.
        //Каждое слово должно быть записано отдельно и взято в кавычки, например "Welcome".
        //Не забывайте о пробелах после каждого слова
        //</summary>
        public static void Task2()
        {
            string s1 = "Welcome";
            string s2 = "to";
            string s3 = "the";
            string s4 = "TMS";
            string s5 = "lessons";
            string s6 = ".";

            Console.WriteLine("{0} {1} {2} {3} {4}{5}", s1, s2, s3, s4, s5, s6); // 

        }
        ///3. Дана строка: teamwithsomeofexcersicesabcwanttomakeitbetter.
        ///Необходимо найти в данной строке "abc", записав всё что до этих символов в первую переменную, а также всё, 
        ///что после них во вторую.
        ///Результат вывести в консоль.
        public static void Task3()
        {
            string str = "teamwithsomeofexcersicesabcwanttomakeitbetter";
            string[] words = str.Split("abc");

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
        /// <summary>
        /// Дана строка: Плохой день.
        /// Необходимо с помощью метода substring удалить слово "плохой". 
        /// После чего необходимо используя команду insert создать строку со значением: Хороший день!!!!
        /// Заменить последний "!" на "?"
        ///</summary>
        public static void Task4()
        {
            string text = "Плохой день"; //создаем строку c переменной
            text = text.Substring(6); //обрезаем строку
            string newtext = "Хороший !!!!"; //создаем строку с новой переменной
            string result = newtext.Insert(7, text);// вставили в новую строку часть из первой строки
            Console.WriteLine(result);
            result = result.Remove(result.Length - 1, 1) + "?";
            Console.WriteLine(result);

        }
        //<summary>  Написать программу со следующим функционалом:
        //        На вход передать строку(будем считать, что это номер документа).
        //Номер документа имеет формат xxxx-yyy-xxxx-yyy-xyxy, где x — это число,
        //а y — это буква.
        //- Вывести на экран в одну строку два первых блока по 4 цифры.
        //- Вывести на экран номер документа, но блоки из трех букв заменить
        //на*** (каждая буква заменятся на*).
        //- Вывести на экран только одни буквы из номера документа в
        //формате yyy/yyy/y/y в нижнем регистре.
        //- Вывести на экран буквы из номера документа в формате
        //"Letters:yyy/yyy/y/y" в верхнем регистре(реализовать с помощью
        //класса StringBuilder).
        //- Проверить содержит ли номер документа последовательность abc и
        //вывети сообщение содержит или нет(причем, abc и ABC считается
        //одинаковой последовательностью).
        //- Проверить начинается ли номер документа с последовательности
        //555.
        //- Проверить заканчивается ли номер документа на
        //последовательность 1a2b.
        //Все эти методы реализовать в отдельном классе в статических методах,
        //которые на вход(входным параметром) будут принимать вводимую на
        //вход программы строку.
        //</summary> 

        public static void PrintFirstTwoBlocks()
        {
            string docNumber = "1234-AAB-5432-DDS-5C4E";
            string[] block = docNumber.Split('-');
            //docNumber = docNumber.Substring(0, docNumber.Length - 5);
            Console.WriteLine(block[0] + block[1]);
        }
        public static void PrintWithoutLetters()
        {
            string docNumber = "1234-AAB-5432-DDS-5C4E";
            for (int i = 0; i <= docNumber.Length; i++)
                if (char.IsLetter(docNumber[i]) && i < docNumber.Length - 4)
                {
                    Console.Write("*");
                }

            else Console.WriteLine(docNumber[i]);
        }

        public static void PrintOnlyLetters()
        {
            string docNumber = "1234-AAB-5432-DDS-5C4E";
            Console.WriteLine(
                (docNumber.Substring(5, 3) + "/" +
                docNumber.Substring(14, 3) + "/" +
                docNumber.Substring(19, 1) + "/" +
                docNumber.Substring(21, 1)).ToLower()); //возвращается копия строки в нижнем регис

        }
        public static void PrintOnlyLettersUsingStringBuilder()
        {
            string docNumber = "1234-AAB-5432-DDS-5C4E";
            StringBuilder sb = new StringBuilder("Letter: ");
            sb.Append(docNumber.Substring(5, 3).ToUpper() + "/");
            sb.Append(docNumber.Substring(14, 3).ToUpper() + "/");
            sb.Append(docNumber.Substring(19, 1).ToUpper() + "/");
            sb.Append(docNumber.Substring(21, 1).ToUpper());
            Console.WriteLine(sb.ToString());

        }
        public static void ContainsABC()
        {
            string docNumber = "1234-AAB-5432-DDS-5C4E";
            if (docNumber.Contains("abc", StringComparison.OrdinalIgnoreCase))
                Console.WriteLine(docNumber + " содержит подстроку 'abc'");
            else Console.WriteLine(docNumber + " не содержит подстроку 'abc'");
        }

        public static void FirstSymbols()
        {
            string docNumber = "1234-AAB-5432-DDS-5C4E";
            if (docNumber.IndexOf("555") == 0)
                Console.WriteLine(docNumber + " начинается на '555'");
            else Console.WriteLine(docNumber + " не начинается на '555'");

        }

        public static void EndSymbols()
        {
            string docNumber = "1234-AAB-5432-DDS-5C4E";
            if (docNumber.IndexOf("1a2b") == docNumber.Length - 4)
                Console.WriteLine(docNumber + " заканчивается на '1a2b'");
            else Console.WriteLine(docNumber + " не заканчивается на'1a2b'");
        }

    }
}