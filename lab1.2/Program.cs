using System;
using System.Text;

namespace CLR_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2a. Объявление строковых литералов и их сравнение
            string literal1 = "Hello";
            string literal2 = "World";
            string literal3 = "Hello";

            Console.WriteLine("Сравнение строковых литералов:");
            Console.WriteLine($"literal1 == literal2: {literal1 == literal2}");
            Console.WriteLine($"literal1 == literal3: {literal1 == literal3}");

            // 2b. Операции со строками на основе String
            string str1 = "Hello";
            string str2 = " ";
            string str3 = "World";

            // Сцепление
            string concatenated = string.Concat(str1, str2, str3);
            Console.WriteLine($"\nСцепление строк: {concatenated}");

            // Копирование
            string copied = string.Copy(concatenated);
            Console.WriteLine($"Копирование строки: {copied}");

            // Выделение подстроки
            string substring = concatenated.Substring(0, 5);
            Console.WriteLine($"Подстрока: {substring}");

            // Разделение строки на слова
            string[] words = concatenated.Split(' ');
            Console.WriteLine("Разделение строки на слова:");
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

            // Вставка подстроки
            string inserted = concatenated.Insert(6, "Beautiful ");
            Console.WriteLine($"Строка после вставки: {inserted}");

            // Удаление подстроки
            string removed = inserted.Remove(6, 10);
            Console.WriteLine($"Строка после удаления подстроки: {removed}");

            // Интерполяция строк
            string name = "John";
            int age = 30;
            string interpolated = $"Имя: {name}, Возраст: {age}";
            Console.WriteLine($"\nИнтерполированная строка: {interpolated}");

            // 2c. Пустая и null строка
            string emptyString = "";
            string nullString = null;

            Console.WriteLine("\nРабота с пустой и null строкой:");
            Console.WriteLine($"string.IsNullOrEmpty(emptyString): {string.IsNullOrEmpty(emptyString)}");
            Console.WriteLine($"string.IsNullOrEmpty(nullString): {string.IsNullOrEmpty(nullString)}");

            // Что еще можно сделать с пустой или null строкой
            Console.WriteLine($"emptyString.Length: {emptyString.Length}");
            // Попытка получить длину строки null вызовет ошибку
            // Console.WriteLine($"nullString.Length: {nullString.Length}"); // Ошибка

            // 2d. Работа со строкой на основе StringBuilder
            StringBuilder sb = new StringBuilder("Hello World");

            // Удаление определённых позиций
            sb.Remove(5, 6);
            Console.WriteLine($"\nStringBuilder после удаления символов: {sb}");

            // Добавление символов в начало и конец строки
            sb.Insert(0, "Start ");
            sb.Append(" End");
            Console.WriteLine($"StringBuilder после вставки символов: {sb}");
        }
    }
}
