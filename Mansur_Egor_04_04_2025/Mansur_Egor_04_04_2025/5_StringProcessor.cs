using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mansur_Egor_04_04_2025
{
    class StringProcessor
    {
        public static void Execute()
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            Console.Write("Введите разделитель (например, пробел или запятая): ");
            string separator = Console.ReadLine();

            if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(separator))
            {
                Console.WriteLine("Ошибка: строка или разделитель пусты.");
                return;
            }

            // Разделение строки
            string[] parts = input.Split(new string[] { separator }, StringSplitOptions.None);

            Console.WriteLine("Разбитые части:");
            foreach (string part in parts)
            {
                Console.WriteLine($"- {part}");
            }

            // Объединение частей с использованием Join()
            string joinedString = string.Join(separator, parts);
            Console.WriteLine($"Объединённая строка (Join): {joinedString}");

            // Объединение частей с использованием StringBuilder
            StringBuilder sb = new StringBuilder();
            foreach (string part in parts)
            {
                if (sb.Length > 0)
                    sb.Append(separator);
                sb.Append(part);
            }

            Console.WriteLine($"Объединённая строка (StringBuilder): {sb.ToString()}");
        }
    }
}
