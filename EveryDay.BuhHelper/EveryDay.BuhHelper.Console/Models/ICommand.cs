using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveryDay.BuhHelper.Console.Models
{
    /// <summary>
    /// Команда бухгалтера
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Наименование
        /// </summary>
        string Name { get; }
        int index { get; set; }

        /// <summary>
        /// Выполнить команду
        /// </summary>
        /// <param name="arg">Входные параметры</param>
        /// <returns>Результат</returns>
        ICommandResult Exec(string arg);
    }


}

