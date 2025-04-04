using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mansur_Egor_04_04_2025
{
    class ComplexStringSplitter
    {
        public static void Execute()
        {
            Console.Write("Введите строку с несколькими значениями, разделёнными запятыми: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Ошибка: пустая строка.");
                return;
            }

            // Разделение строки, удаляя лишние пробелы
            string[] elements = input.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Полученные значения:");
            foreach (string element in elements)
            {
                Console.WriteLine($"- {element.Trim()}");
            }
        }
    }
}
