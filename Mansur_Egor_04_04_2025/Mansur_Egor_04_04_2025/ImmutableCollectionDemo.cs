using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mansur_Egor_04_04_2025
{
    class ImmutableCollectionDemo
    {
        public static void Execute()
        {
            // Создание неизменяемого списка
            ImmutableList<int> immutableNumbers = ImmutableList.Create(1, 2, 3, 4, 5);

            Console.WriteLine("Исходный неизменяемый список:");
            Console.WriteLine(string.Join(", ", immutableNumbers));

            // Попытка добавить элемент
            ImmutableList<int> newImmutableNumbers = immutableNumbers.Add(6);
            Console.WriteLine("Добавленный элемент (создана новая коллекция):");
            Console.WriteLine(string.Join(", ", newImmutableNumbers));

            // Попытка удалить элемент
            ImmutableList<int> removedImmutableNumbers = immutableNumbers.Remove(3);
            Console.WriteLine("Удаленный элемент (создана новая коллекция):");
            Console.WriteLine(string.Join(", ", removedImmutableNumbers));

            Console.WriteLine("Оригинальный список остаётся неизменным:");
            Console.WriteLine(string.Join(", ", immutableNumbers));
        }
    }
}