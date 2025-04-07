using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mansur_Egor_04_04_2025
{
    internal class UriParserDemo
    {
        public static void Execute()
        {
            Console.WriteLine("Введите URL:");
            string inputUrl = Console.ReadLine();

            try
            {
                Uri uri = new Uri(inputUrl);

                Console.WriteLine("\nАнализ URL:");
                Console.WriteLine($"Схема: {uri.Scheme}");
                Console.WriteLine($"Хост: {uri.Host}");
                Console.WriteLine($"Путь: {uri.AbsolutePath}");
                Console.WriteLine($"Параметры запроса: {uri.Query}");
            }
            catch (UriFormatException)
            {
                Console.WriteLine("Ошибка: Некорректный URL!");
            }
        }
    }
}
