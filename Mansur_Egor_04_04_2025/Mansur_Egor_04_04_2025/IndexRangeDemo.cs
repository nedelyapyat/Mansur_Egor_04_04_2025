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

            Index lastIndex = ^1; // Последний элемент
            Range middleRange = 2..6; // Элементы с индекса 2 по 5 (6 не включается)

            Console.WriteLine($"Последний элемент: {numbers[lastIndex]}");

            int[] middleArray = numbers[middleRange];
            Console.WriteLine("Подмассив (индексы 2-5):");
            Console.WriteLine(string.Join(", ", middleArray));

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
