using System.CommandLine;

namespace NDocker.Conosle
{
    class Program
    {
        static async Task<int> Main(string[] args)
        {
            var greetOption = new Option<string?>(
                name: "--greet",
                description: "greet someone");


            var rootCommand = new RootCommand("Sample app for System.CommandLine");
            rootCommand.AddOption(greetOption);

            rootCommand.SetHandler((name) =>
            {
                Console.WriteLine(name);
            },
                greetOption);

            return await rootCommand.InvokeAsync(args);
        }
    }
}