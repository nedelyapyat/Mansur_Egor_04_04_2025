using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mansur_Egor_04_04_2025
{
    class IndexRangeDemo
    {
        public static void Execute()
        {
            // Работа с массивом
            int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            Console.WriteLine("Исходный массив:");
            Console.WriteLine(string.Join(", ", numbers));

            // Использование Index
            Index firstIndex = new Index(3); // Четвёртый элемент с начала
            Index lastIndex = new Index(5, fromEnd: true); // Пятый элемент с конца

            Console.WriteLine($"Элемент на позиции {firstIndex.Value}: {numbers[firstIndex]}");
            Console.WriteLine($"Элемент на позиции -{lastIndex.Value} (с конца): {numbers[lastIndex]}");

            // Использование Range
            Range range1 = new Range(3, 7); // Элементы с индекса 3 по 6 (7 не включается)
            Range range2 = ..5; // Первые 5 элементов
            Range range3 = 5..; // Элементы, начиная с 5-го и до конца

            Console.WriteLine("Подмассив (индексы 3-6):");
            Console.WriteLine(string.Join(", ", numbers[range1]));

            Console.WriteLine("Первые 5 элементов:");
            Console.WriteLine(string.Join(", ", numbers[range2]));

            Console.WriteLine("Элементы с 5-го до конца:");
            Console.WriteLine(string.Join(", ", numbers[range3]));

            // Работа со строкой
            string text = "Привет, мир! Добро пожаловать в C#.";

            Console.WriteLine("\nИсходная строка:");
            Console.WriteLine(text);

            Index startIndex = ^5; // Пятый символ с конца
            Range substringRange = 0..6; // Первые 6 символов

            Console.WriteLine($"Символ на позиции -5 (с конца): {text[startIndex]}");
            Console.WriteLine($"Подстрока (первые 6 символов): {text[substringRange]}");
        }
    }
}
