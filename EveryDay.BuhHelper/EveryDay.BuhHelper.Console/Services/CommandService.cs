using EveryDay.BuhHelper.Console.Commands;
using EveryDay.BuhHelper.Console.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveryDay.BuhHelper.Console.Services
{
    public class CommandService : ICommandService
    {
        public ICommandResult ExecCommand(string name, string arg)
        {
            throw new NotImplementedException();
        }

        public List<ICommand> GetCommands()
        {
            System.Console.WriteLine("Список доступных команд");
            var list = new List<ICommand>();

            int i = 1;
            System.Console.Write(i+" "); 
            list.Add(new KonturINNCommand());
            KonturINNCommand.Index = i;



            list.Add(new godCommand());

            list.Add(new number_daysCommand());



            return list;
        }
    }
}
