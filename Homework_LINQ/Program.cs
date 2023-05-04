
namespace Homework_LINQ
{
    public class Program
    {
        public static void Main()
        {
            // Реализовать следующие методы:
            // 1.Метод возвращает первое слово из последовательности слов, содержащее только одну букву.
            // 2.метод, возвращающий последнее слово, содержащее в себе подстроку «ее». Реализовать, используя только 1 метод LINQ.
            // 3.Реализовать метод для возврата последнего слова, соответствующего условию: длина слова не меньше min и не больше max.
            //  Если нет слов, соответствующих условию, метод возвращает null.
            //4. Напишите метод, который возвращает количество уникальных значений в массиве.
            // Напишите метод, который принимает список и извлекает значения с 5  элемента(включительно)  те значение которые содержат 3
            //6. Метод возвращает длину самого короткого слова
            // Напишите метод, который преобразует словарь в список и меняет местами каждый ключ и значение

            List<string> words = new List<string> { "au", "ооп", "иванее", "aa", "@#e%", "апее", "a" };
            List<User> users = new List<User> {

                new User("Виктор", "", "ВВВВВ"),
                new User("Иван", "Иванович", "Иванов"),
                new User("Петя", "Петрович", "Петров"),
                new User("Андрей", "", "Гап"),
                new User("Виктор", "", "ЯЯВВВ"),
            };

            Console.WriteLine(FindFirstWord(words));
            Console.WriteLine(FindLastWord(words));
            Console.WriteLine(FindLastWordWithLengthCondition(words, 2, 7));
            Console.WriteLine(FindDistinctWord(words));
            Console.WriteLine(FindMinLenghtWord(words));

            var result = GetUserOrderbyLastName(users);
            foreach (var user in result) 
                Console.WriteLine(GetUserInformation(user));
        }

        public static string FindFirstWord(List<string> words)
        {
            return words.First(o => o.Count(b => Char.IsLetter(b)) == 1);
        }

        public static string FindLastWord(List<string> words)
        {
            return words.Last(x => x.Contains("ее"));
        }
        public static string? FindLastWordWithLengthCondition(List<string> words, int min, int max)
        {
            return words.LastOrDefault(f => f.Length >= min && f.Length <= max, null);
        }
        public static int FindDistinctWord(List<string> words)
        {
            return words.Distinct().ToList().Count;
        }

        public static int FindMinLenghtWord(List<string> words)
        {
            return words.Min(x => x.Length);
        }

        public static string GetUserInformation(User user)
        {
            if (string.IsNullOrEmpty(user.MiddleName))
            {
                return user.ToShortFormat();
            }
            else
            {
                return user.ToLongFormat();
            }
        }
        
        public static List<User> GetUserOrderbyLastName(List<User> users)
        {
            return users.OrderByDescending(x => x.LastName).ToList();
        }
    }
}
