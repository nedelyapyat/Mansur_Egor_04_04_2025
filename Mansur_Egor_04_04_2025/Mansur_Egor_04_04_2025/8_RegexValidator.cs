using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mansur_Egor_04_04_2025
{
    class RegexValidator
    {
        public static void Execute()
        {
            Console.Write("Введите номер телефона (+XXX-XXX-XXXX или XXX-XXX-XXXX): ");
            string phoneInput = Console.ReadLine();

            Console.Write("Введите email: ");
            string emailInput = Console.ReadLine();

            if (!IsValidPhone(phoneInput))
                Console.WriteLine("Ошибка: Некорректный формат номера телефона.");
            else
                Console.WriteLine("Телефонный номер корректен.");

            if (!IsValidEmail(emailInput))
                Console.WriteLine("Ошибка: Некорректный формат email.");
            else
                Console.WriteLine("Email корректен.");
        }

        private static bool IsValidPhone(string phone)
        {
            string pattern = @"^(\+?\d{1,3}-?)?\d{3}-\d{3}-\d{4}$";
            return Regex.IsMatch(phone, pattern);
        }

        private static bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
