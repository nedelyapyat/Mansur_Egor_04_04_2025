using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mansur_Egor_04_04_2025
{
    class DateExtractor
    {
        public static void Execute()
        {
            Console.Write("Введите текст: ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Ошибка: текст пуст.");
                return;
            }

            // Регулярное выражение для поиска дат в формате dd.MM.yyyy
            string pattern = @"\b(0[1-9]|[12][0-9]|3[01])\.(0[1-9]|1[0-2])\.(\d{4})\b";
            MatchCollection matches = Regex.Matches(input, pattern);

            if (matches.Count > 0)
            {
                Console.WriteLine("Найденные даты:");
                foreach (Match match in matches)
                {
                    Console.WriteLine($"- {match.Value}");
                }
            }
            else
            {
                Console.WriteLine("Даты не найдены.");
            }
        }
    }
}
