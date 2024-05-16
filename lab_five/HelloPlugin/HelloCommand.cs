using PluginBase;
using System;

namespace HelloPlugin
{
    public class HelloCommand : ICommand
    {
        public string Name { get => "hello"; }
        public string Description { get => "Displays hello message."; }

        public int Execute(string? msg)
        {
            Console.WriteLine($"Hello !!! {msg}");
            return 0;
        }
    }
}