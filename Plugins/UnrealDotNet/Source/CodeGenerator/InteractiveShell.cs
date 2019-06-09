using System;
using System.Collections.Generic;
using System.Linq;
using CodeGenerator.Metadata;
using Type = CodeGenerator.Metadata.Type;

namespace CodeGenerator
{
    public class InteractiveShell
    {
        private readonly CommandLineArguments _args;
        private readonly Config _config;
        private Domain _domain;

        public InteractiveShell(Config config, CommandLineArguments args)
        {
            _domain = new Domain(new List<Type>(), config);
            _config = config;
            _args = args;
        }

        public void Enter()
        {
            Console.WriteLine("Interactive shell ready");

            while (true)
            {
                Console.ResetColor();
                Console.Write(">");

                var line = Console.ReadLine()?.Split(' ');
                var args = line.Skip(1).ToArray();

                switch (line.FirstOrDefault())
                {
                    case "parce":
                        RunParce(args);
                        break;

                    case "gen":
                        Program.GenarateDomain(_domain, _args.Output, _config);
                        break;

                    case "domain":
                        _domain.Print(false);
                        break;

                    case "class":
                        FindClass(args);
                        break;

                    case "deps":
                        FindDependent(line.Skip(1).ToArray());
                        break;

                    case "exit":
                        Environment.Exit(0);
                        return;

                    case "h":
                    case "help":
                        Console.WriteLine("parce <FileName>");
                        Console.WriteLine("gen");
                        Console.WriteLine("domain");
                        Console.WriteLine("class <ClassName>");
                        Console.WriteLine("deps <ClassName>");
                        Console.WriteLine("exit");
                        break;

                    case "":
                        break;
                    
                    default:
                        Console.WriteLine("Undefine command, use 'help'");
                        break;
                }
            }
        }
        
        private void RunParce(string[] args)
        {
            var files = new List<string>();

            if (args.Length == 0)
            {
                files = Program.GetScanFiles(_args);
            }
            else
            {
                files.Add(string.Join(' ', args));
            }

            _domain = ParceManager.Parce(files, _config);
        }

        private Class GetClass(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Missing argument - ClassName");
                return null;
            }

            var className = args.First().ToLower();

            var cls = _domain.Classes.Where(x => x.FullName.ToLower().Contains(className)).ToList();
            var selectClass = cls.FirstOrDefault(x => x.FullName.ToLower() == className);

            if (selectClass != null)
            {
                return selectClass;
            }

            if (cls.Any())
            {
                foreach (var cl in cls)
                {
                    Console.WriteLine(cl.FullName);
                }
            }
            else
            {
                Console.WriteLine("Class not found");
            }

            return null;
        }

        private void FindDependent(string[] args)
        {
            var cl = GetClass(args);

            if (cl == null)
                return;

            foreach (var type in cl.Dependent)
            {
                Console.WriteLine(type.FullName);
            }
        }

        private void FindClass(string[] args)
        {
            var cl = GetClass(args);

            if (cl == null)
                return;

            if (args.Length > 1)
            {
                var methodName = args[1];
            }
            else
            {
                _domain.PrintClass(cl, true);

                var canExport = _config.Filter.FilterClasses(new[] {cl}).Any();
                var canManage = _config.Filter.CanGenerateManageType(cl);

                Console.WriteLine($"Can be generate wrapper - {canExport}");
                Console.WriteLine($"Can be generate Manage wrapper - {canManage}");
            }
        }
    }
}