﻿using PluginBase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace AppWithPlugin
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Load commands from plugins.
                string[] pluginPaths = new string[]
                {
                    // Paths to plugins to load.
                    @"HelloPlugin\bin\Debug\net8.0\HelloPlugin.dll",
                    @"WhatsappPlugin\bin\Debug\net8.0\WhatsappPlugin.dll"
                };

                IEnumerable<ICommand> commands = pluginPaths.SelectMany(pluginPath =>
                {
                    Assembly pluginAssembly = LoadPlugin(pluginPath);
                    return CreateCommands(pluginAssembly);
                }).ToList();

                for(;;)
                {
                    Console.WriteLine("\nВведите <команду> и <текст> или help, или exit: ");
                    string? choose = Console.ReadLine();
                    string[] msg = choose!.Split(new char[] { ' ' });

                    if(msg[0] == "exit") break;

                    if(msg[0] == "help")
                    {
                        Console.WriteLine("\nCommands: ");
                        // Output the loaded commands.
                        foreach (ICommand command in commands)
                        {
                            Console.WriteLine($"{command.Name} <txt> - {command.Description}");
                        }
                        Console.WriteLine("help - Получить список всех команд \nexit - Выход");
                    }
                    else
                    {
                        if(msg.Length == 1) 
                        {
                            Console.WriteLine("Введите <текст> после команды");
                            continue;
                        }
                        string? commandName = msg[0];
                        Console.WriteLine($"\n-- {commandName} --");

                        // Execute the command with the name passed as an argument.
                        ICommand? command = commands.FirstOrDefault(c => c.Name == commandName);
                        if (command == null)
                        {
                            Console.WriteLine("No such command is known.");
                            // return;
                        }

                        command?.Execute(msg[1]);

                        Console.WriteLine();
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        static Assembly LoadPlugin(string relativePath)
        {
            // Navigate up to the solution root
            string root = Path.GetFullPath(Path.Combine(
                Path.GetDirectoryName(
                    Path.GetDirectoryName(
                        Path.GetDirectoryName(
                            Path.GetDirectoryName(
                                Path.GetDirectoryName(typeof(Program).Assembly.Location)))))!));

            string pluginLocation = Path.GetFullPath(Path.Combine(root, relativePath.Replace('\\', Path.DirectorySeparatorChar)));
            Console.WriteLine($"Loading commands from: {pluginLocation}");
            PluginLoadContext loadContext = new PluginLoadContext(pluginLocation);
            return loadContext.LoadFromAssemblyName(new AssemblyName(Path.GetFileNameWithoutExtension(pluginLocation)));
        }

        static IEnumerable<ICommand> CreateCommands(Assembly assembly)
        {
            int count = 0;

            foreach (Type type in assembly.GetTypes())
            {
                if (typeof(ICommand).IsAssignableFrom(type))
                {
                    ICommand? result = Activator.CreateInstance(type) as ICommand;
                    if (result != null)
                    {
                        count++;
                        yield return result;
                    }
                }
            }

            if (count == 0)
            {
                string availableTypes = string.Join(",", assembly.GetTypes().Select(t => t.FullName));
                throw new ApplicationException(
                    $"Can't find any type which implements ICommand in {assembly} from {assembly.Location}.\n" +
                    $"Available types: {availableTypes}");
            }
        }
    }
}