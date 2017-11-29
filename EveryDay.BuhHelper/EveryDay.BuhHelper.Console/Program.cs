using EveryDay.BuhHelper.Console.Models;
using EveryDay.BuhHelper.Console.Services;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Net;

namespace EveryDay.BuhHelper
{

    class Program
    {
        static ICommandService CommandService { get; set; }

        static void Main(string[] args)
        {
            CommandService = new CommandService();

            // получить список команд
            var commands = CommandService.GetCommands();

            // вывести их на экран
            foreach (var item in commands)
            {
                
                System.Console.WriteLine(item.Name);
            }

            // получаем ввод пользователя
            var select = System.Console.ReadLine();

            // определяем выбранную команду
            // лямда-выражение
            // делегаты
            var selectCommand = commands.FirstOrDefault(c => c.Name == select);

            if (selectCommand == null)
            {
                // выводим пользователю ошибку
                System.Console.WriteLine("Вы ошиблись в названии команды");
            }
            else
            {
                // выполянем команду
                System.Console.WriteLine("введите исходные данные");
                var input = System.Console.ReadLine();
                var result = selectCommand.Exec(input);
                // выводим пользователю результат или ошибку
                System.Console.WriteLine(result.Success ? result.Result : result.Error);

            }
            System.Console.ReadKey();
        }
    }


}
