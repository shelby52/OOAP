using System;

namespace CLR_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1a. Примитивные типы
            bool myBool = true;
            byte myByte = 255;
            sbyte mySByte = -128;
            char myChar = 'A';
            decimal myDecimal = 10.5m;
            double myDouble = 20.99;
            float myFloat = 5.75f;
            int myInt = 42;
            uint myUInt = 4000000000;
            long myLong = 3000000000;
            ulong myULong = 18446744073709551615;
            short myShort = -32768;
            ushort myUShort = 65535;

            // Вывод примитивных типов
            Console.WriteLine("Примитивные типы:");
            Console.WriteLine($"bool: {myBool}");
            Console.WriteLine($"byte: {myByte}");
            Console.WriteLine($"sbyte: {mySByte}");
            Console.WriteLine($"char: {myChar}");
            Console.WriteLine($"decimal: {myDecimal}");
            Console.WriteLine($"double: {myDouble}");
            Console.WriteLine($"float: {myFloat}");
            Console.WriteLine($"int: {myInt}");
            Console.WriteLine($"uint: {myUInt}");
            Console.WriteLine($"long: {myLong}");
            Console.WriteLine($"ulong: {myULong}");
            Console.WriteLine($"short: {myShort}");
            Console.WriteLine($"ushort: {myUShort}");

            // 1b. Явное и неявное приведение
            // Неявное приведение
            int a = 10;
            double b = a; // int -> double (неявно)

            float c = 5.5f;
            double d = c; // float -> double (неявно)

            byte e = 255;
            int f = e; // byte -> int (неявно)

            short g = 30000;
            long h = g; // short -> long (неявно)

            char i = 'A';
            int j = i; // char -> int (неявно)

            // Явное приведение
            double x = 9.8;
            int y = (int)x; // Явное приведение

            long z = 123456789;
            int w = (int)z; // Явное приведение

            int m = 256;
            byte n = (byte)m; // Явное приведение

            float p = 45.6f;
            int q = (int)p; // Явное приведение

            decimal r = 99.99m;
            double s = (double)r; // Явное приведение

            Console.WriteLine($"\nЯвное и неявное приведение:");
            Console.WriteLine($"int -> double: {b}");
            Console.WriteLine($"float -> double: {d}");
            Console.WriteLine($"byte -> int: {f}");
            Console.WriteLine($"short -> long: {h}");
            Console.WriteLine($"char -> int: {j}");
            Console.WriteLine($"double -> int: {y}");
            Console.WriteLine($"long -> int: {w}");
            Console.WriteLine($"int -> byte: {n}");
            Console.WriteLine($"float -> int: {q}");
            Console.WriteLine($"decimal -> double: {s}");

            // 1c. Упаковка и распаковка
            int value = 123;
            object boxed = value; // Упаковка
            int unboxed = (int)boxed; // Распаковка

            Console.WriteLine($"\nУпаковка и распаковка:");
            Console.WriteLine($"Упакованное значение: {boxed}");
            Console.WriteLine($"Распакованное значение: {unboxed}");

            // 1d. Неявная типизация (var)
            var number = 10;
            Console.WriteLine($"\nТип переменной number (var): {number.GetType()}");

            // 1e. Nullable переменные
            int? nullableInt = null;
            Console.WriteLine("\nNullable переменная:");
            if (nullableInt.HasValue)
            {
                Console.WriteLine($"Nullable переменная содержит значение: {nullableInt.Value}");
            }
            else
            {
                Console.WriteLine("Nullable переменная не содержит значения");
            }

            // 1f. Пример с ошибкой var
            var myVar = 10; // Переменная myVar теперь типа int
            // myVar = "String"; // Ошибка: нельзя присвоить строку переменной, которая была определена как int
            Console.WriteLine($"Тип переменной myVar: {myVar.GetType()}");
        }
    }
}
