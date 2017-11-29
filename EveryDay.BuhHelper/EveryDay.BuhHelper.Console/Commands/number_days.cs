using EveryDay.BuhHelper.Console.Models;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Net;

namespace EveryDay.BuhHelper.Console.Commands
{
    public class number_daysCommand : ICommand
    {
        
        public string Name => "numbers_day";
        public int index => 0;

        public ICommandResult Exec(string arg)
        {
            
            var result = new CommandResult();

            DateTime date1 = new DateTime();
            date1 = DateTime.Today;

            var kolvo = DateTime.DaysInMonth(2017, 11);

            result.Result = kolvo.ToString();

            result.Success = true;

            return result;
        }
    }
}
