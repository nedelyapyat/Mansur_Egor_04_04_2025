using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mansur_Egor_04_04_2025
{
    class SubstringSearcher
    {
        public static void Execute()
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            Console.Write("Введите искомое слово или фразу: ");
            string searchQuery = Console.ReadLine();

            if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(searchQuery))
            {
                Console.WriteLine("Ошибка: текст или искомая строка пусты.");
                return;
            }

            int position = text.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase);

            if (position != -1)
            {
                Console.WriteLine($"Искомая строка найдена на позиции {position}.");
            }
            else
            {
                Console.WriteLine("Искомая строка не найдена.");
            }
        }
    }
}
