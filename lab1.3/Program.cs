using System;

namespace CLR_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3a. Создание целого двумерного массива и вывод его на консоль
            int[,] twoDimensionalArray = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            Console.WriteLine("Двумерный массив:");
            for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
                {
                    Console.Write($"{twoDimensionalArray[i, j],3} ");
                }
                Console.WriteLine();
            }

            // 3b. Создание одномерного массива строк
            string[] stringArray = { "Apple", "Banana", "Cherry" };
            Console.WriteLine($"\nОдномерный массив строк:");
            Console.WriteLine($"Длина массива: {stringArray.Length}");
            foreach (var item in stringArray)
            {
                Console.WriteLine(item);
            }

            // Замена произвольного элемента
            Console.WriteLine("\nВведите индекс элемента для замены (0 - 2):");
            int index = int.Parse(Console.ReadLine());
            if (index >= 0 && index < stringArray.Length)
            {
                Console.WriteLine("Введите новое значение:");
                string newValue = Console.ReadLine();
                stringArray[index] = newValue;
                Console.WriteLine($"Элемент на позиции {index} изменён на: {stringArray[index]}");
            }
            else
            {
                Console.WriteLine("Некорректный индекс.");
            }

            // 3c. Создание ступенчатого массива вещественных чисел
            double[][] jaggedArray = new double[3][];
            jaggedArray[0] = new double[2]; // 2 столбца
            jaggedArray[1] = new double[3]; // 3 столбца
            jaggedArray[2] = new double[4]; // 4 столбца

            Console.WriteLine("\nВведите значения для ступенчатого массива:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"Элемент [{i}, {j}]: ");
                    jaggedArray[i][j] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nСтупенчатый массив:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"{jaggedArray[i][j],6:F2} ");
                }
                Console.WriteLine();
            }

            // 3d. Неявно типизированные переменные для хранения массива и строки
            var implicitArray = new[] { 1, 2, 3, 4, 5 }; // Неявно типизированный массив
            var implicitString = "Неявно типизированная строка"; // Неявно типизированная строка

            Console.WriteLine($"\nНеявно типизированный массив: {string.Join(", ", implicitArray)}");
            Console.WriteLine($"Неявно типизированная строка: {implicitString}");
        }
    }
}
