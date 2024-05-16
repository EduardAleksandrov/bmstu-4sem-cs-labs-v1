using PluginBase;
using System;

namespace HelloPlugin
{
    public class HelloCommand : ICommand
    {
        public string Name { get => "whatsapp"; }
        public string Description { get => "Displays whatsapp message."; }

        public int Execute(string? msg)
        {
            Console.WriteLine($"Whatsapp !!! {msg}");
            return 0;
        }
    }
}