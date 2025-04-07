using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mansur_Egor_04_04_2025
{
    // Определение пользовательского атрибута
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    class ClassInfoAttribute : Attribute
    {
        public string Author { get; }
        public string Version { get; }

        public ClassInfoAttribute(string author, string version)
        {
            Author = author;
            Version = version;
        }
    }

    // Применение атрибута к классам и методам
    [ClassInfo("Мансур", "1.0")]
    class MyClassA
    {
        [ClassInfo("Мансур", "1.1")]
        public void MethodA() { }
    }

    [ClassInfo("Егор", "2.0")]
    class MyClassB
    {
        [ClassInfo("Егор", "2.1")]
        public void MethodB() { }
    }

    class AttributeReader
    {
        public static void Execute()
        {
            Type[] types = { typeof(MyClassA), typeof(MyClassB) };

            foreach (Type type in types)
            {
                Console.WriteLine($"Класс: {type.Name}");

                // Получение атрибутов класса
                var classAttributes = type.GetCustomAttributes<ClassInfoAttribute>();
                foreach (var attr in classAttributes)
                {
                    Console.WriteLine($"  Автор: {attr.Author}, Версия: {attr.Version}");
                }

                // Получение атрибутов методов
                foreach (MethodInfo method in type.GetMethods())
                {
                    var methodAttributes = method.GetCustomAttributes<ClassInfoAttribute>();
                    foreach (var attr in methodAttributes)
                    {
                        Console.WriteLine($"  Метод: {method.Name}, Автор: {attr.Author}, Версия: {attr.Version}");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
