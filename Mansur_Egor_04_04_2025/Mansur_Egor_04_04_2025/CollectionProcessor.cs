using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mansur_Egor_04_04_2025
{
    class CollectionProcessor
    {
        public static void Execute()
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("Введите числа (через пробел), затем нажмите Enter:");
            string input = Console.ReadLine();

            string[] parts = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string part in parts)
            {
                if (int.TryParse(part, out int num))
                    numbers.Add(num);
                else
                    Console.WriteLine($"Предупреждение: '{part}' не является числом и будет проигнорировано.");
            }

            // Сортировка списка
            numbers.Sort();
            Console.WriteLine("Отсортированные числа:");
            Console.WriteLine(string.Join(", ", numbers));

            // Удаление дубликатов с использованием SortedSet
            SortedSet<int> uniqueSortedNumbers = new SortedSet<int>(numbers);
            Console.WriteLine("Уникальные и отсортированные значения:");
            Console.WriteLine(string.Join(", ", uniqueSortedNumbers));
        }
    }
}
