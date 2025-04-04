using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mansur_Egor_04_04_2025
{
    class SubstringExtractor
    {
        public static void Execute()
        {
            Console.Write("Введите текст: ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Ошибка: Пустая строка.");
                return;
            }

            Console.WriteLine($"Первые 10 символов: {ExtractSubstring(input, 0, 10)}");
            Console.WriteLine($"С 5-й по 15-ю позицию: {ExtractSubstring(input, 5, 15)}");
        }

        private static string ExtractSubstring(string text, int start, int end)
        {
            if (start < 0 || end > text.Length || start >= end)
                return "Ошибка: Неправильные границы подстроки.";

            return text.Substring(start, end - start);
        }
    }
}
