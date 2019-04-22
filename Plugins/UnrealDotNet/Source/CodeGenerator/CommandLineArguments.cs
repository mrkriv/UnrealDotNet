using CommandLine;

namespace CodeGenerator
{
    public class CommandLineArguments
    {
        [Option('o', "output", Required = true, HelpText = "Output code folder")]
        public string Output { get; set; }

        [Option("ue", Required = true, HelpText = "Unreal engine 4 root folder")]
        public string UnrealEngine { get; set; }

        [Option('h', "headers", HelpText = "Path to header filters", Default = @"HeaderScanList.txt")]
        public string HeaderScanListFile { get; set; }

        [Option('c', "config", HelpText = "Path to config file", Default = @"CodeGenerator.json")]
        public string ConfigPath { get; set; }
    }
}