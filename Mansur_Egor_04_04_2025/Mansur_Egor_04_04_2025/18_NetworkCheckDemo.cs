using System;
using System.Net.NetworkInformation;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mansur_Egor_04_04_2025
{
    class NetworkCheckDemo
    {
        public static async Task Execute()
        {
            Console.WriteLine("Введите адрес сервера (например, google.com):");
            string serverAddress = Console.ReadLine();

            // Проверка доступности через Ping
            try
            {
                using (Ping ping = new Ping())
                {
                    PingReply reply = ping.Send(serverAddress);

                    Console.WriteLine($"\nPing-статус: {reply.Status}");
                    if (reply.Status == IPStatus.Success)
                    {
                        Console.WriteLine($"Время отклика: {reply.RoundtripTime} мс");
                    }
                }
            }
            catch (PingException)
            {
                Console.WriteLine("Ошибка Ping: Сервер недоступен или заблокирован.");
            }

            // Проверка доступности через HTTP-запрос
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync($"http://{serverAddress}");
                    Console.WriteLine($"\nHTTP-статус: {response.StatusCode}");
                }
            }
            catch (HttpRequestException)
            {
                Console.WriteLine("Ошибка HTTP-запроса: Сервер недоступен.");
            }
        }
    }
}
