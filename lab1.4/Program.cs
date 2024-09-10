using System;

namespace CLR_Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4a. Задание кортежа из 5 элементов
            var myTuple = (1, "Hello", 'A', "World", 123456789UL);

            // 4b. Вывод кортежа на консоль целиком и выборочно
            Console.WriteLine("Кортеж:");
            Console.WriteLine($"Целиком: {myTuple}");
            Console.WriteLine($"1 элемент: {myTuple.Item1}");
            Console.WriteLine($"3 элемент: {myTuple.Item3}");
            Console.WriteLine($"4 элемент: {myTuple.Item4}");

            // 4c. Распаковка кортежа в переменные
            (int num, string greeting, char letter, string anotherString, ulong ulongNum) = myTuple;
            Console.WriteLine($"\nРаспаковка кортежа:");
            Console.WriteLine($"num: {num}, greeting: {greeting}, letter: {letter}, anotherString: {anotherString}, ulongNum: {ulongNum}");

            // Альтернативная распаковка с использованием _
            var (value, _, _, str, ulongValue) = myTuple;
            Console.WriteLine($"\nИспользование переменной _: {str}, ulongValue: {ulongValue}");

            // 4d. Сравнение двух кортежей
            var anotherTuple = (1, "Hello", 'A', "World", 123456789UL);
            Console.WriteLine($"\nСравнение кортежей: {myTuple == anotherTuple}");

            // 5. Локальная функция
            var result = GetArrayInfo(new int[] { 1, 2, 3, 4, 5 }, "Example");
            Console.WriteLine($"\nРезультат локальной функции: max: {result.max}, min: {result.min}, sum: {result.sum}, first letter: {result.firstLetter}");

            // 6. Работа с checked/unchecked
            CheckedFunction();
            UncheckedFunction();
        }

        // Локальная функция, возвращающая кортеж
        static (int max, int min, int sum, char firstLetter) GetArrayInfo(int[] numbers, string str)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            int sum = 0;

            foreach (var num in numbers)
            {
                if (num > max) max = num;
                if (num < min) min = num;
                sum += num;
            }

            char firstLetter = str[0];
            return (max, min, sum, firstLetter);
        }

        // Локальная функция с checked
        static void CheckedFunction()
        {
            int maxValue = int.MaxValue;
            try
            {
                int overflowValue = checked(maxValue + 1);
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nChecked: Произошло переполнение.");
            }
        }

        // Локальная функция с unchecked
        static void UncheckedFunction()
        {
            int maxValue = int.MaxValue;
            int overflowValue = unchecked(maxValue + 1);
            Console.WriteLine($"Unchecked: Переполнение произошло, значение = {overflowValue}");
        }
    }
}
