using EveryDay.BuhHelper.Console.Models;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace EveryDay.BuhHelper.Console.Commands
{
    public class godCommand : ICommand
    {
        

        public string Name => "god";
        public int index => 0;
        index = 0;

        public ICommandResult Exec(string arg)
        {
            var result = new CommandResult();

            

            result.Result = "а год сейчас 2017 или 2018. как-то так, вряд ли другой.";

            result.Success = true;

            return result;
        }
    }
}
