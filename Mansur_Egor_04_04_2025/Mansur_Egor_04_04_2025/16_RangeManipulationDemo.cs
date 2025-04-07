using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mansur_Egor_04_04_2025
{
    class RangeManipulationDemo
    {
        public static void Execute()
        {
            // Исходный массив
            int[] numbers = { 15, 8, 42, 31, 56, 19, 73, 21, 90, 67 };

            Console.WriteLine("Исходный массив:");
            Console.WriteLine(string.Join(", ", numbers));

            // Извлечение подмассива (с 3-го по 7-й индекс)
            int[] extractedNumbers = numbers[3..8];

            Console.WriteLine("\nИзвлечённый подмассив (индексы 3-7):");
            Console.WriteLine(string.Join(", ", extractedNumbers));

            // Сортировка подмассива
            int[] sortedNumbers = extractedNumbers.OrderBy(n => n).ToArray();

            Console.WriteLine("\nОтсортированный подмассив:");
            Console.WriteLine(string.Join(", ", sortedNumbers));

            // Суммирование элементов подмассива
            int sum = extractedNumbers.Sum();
            Console.WriteLine($"\nСумма элементов подмассива: {sum}");
        } 
    }
}
