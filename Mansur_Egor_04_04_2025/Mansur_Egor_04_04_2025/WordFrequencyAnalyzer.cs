using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mansur_Egor_04_04_2025
{
    class WordFrequencyAnalyzer
    {
        public static void Execute()
        {
            Console.Write("Введите текст для анализа: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Ошибка: текст пуст.");
                return;
            }

            // Разделение текста на слова, игнорируя знаки пунктуации
            char[] delimiters = { ' ', ',', '.', ';', ':', '!', '?' };
            string[] words = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            foreach (string word in words)
            {
                string normalizedWord = word.ToLower(); // Приведение к единому регистру
                if (wordCount.ContainsKey(normalizedWord))
                    wordCount[normalizedWord]++;
                else
                    wordCount[normalizedWord] = 1;
            }

            // Вывод частоты встречаемости слов, отсортированных по убыванию
            Console.WriteLine("Частота встречаемости слов:");
            foreach (var pair in wordCount.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
