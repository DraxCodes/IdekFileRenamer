using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using StarWarsApiSharp.Extensions;
using Color = System.Drawing.Color;
using Console = Colorful.Console;

namespace FileRenamer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            InitializeConsoleHeader();
            Log("Initializing Services!");
            await Task.Delay(2000);
            var services = SetupServiceCollection();

            Log("Renaming File & Writing new Contents");
            await Task.Delay(3000);
            services.GetRequiredService<FileRenamer>().ChangeFileNameAndContents(10);

            Log($"Done! File can be found: {Directory.GetCurrentDirectory()}");
            Log("Press any key to exit.");
            Console.ReadLine();
        }

        private static void Log(string message)
        {
            Console.WriteLine(message, Color.FromArgb(163, 75, 163));
        }

        private static IServiceProvider SetupServiceCollection()
            => new ServiceCollection()
                .UseStarwarsApi()
                .AddTransient<FileRenamer>()
                .BuildServiceProvider();

        private static void InitializeConsoleHeader()
        {
            const string header = @"
            █▀▀ ░▀░ █░░ █▀▀   █▀▀█ █▀▀ █▀▀▄ █▀▀█ █▀▄▀█ █▀▀ █▀▀█
            █▀▀ ▀█▀ █░░ █▀▀   █▄▄▀ █▀▀ █░░█ █▄▄█ █░▀░█ █▀▀ █▄▄▀
            ▀░░ ▀▀▀ ▀▀▀ ▀▀▀   ▀░▀▀ ▀▀▀ ▀░░▀ ▀░░▀ ▀░░░▀ ▀▀▀ ▀░▀▀";
            var lineBreak = $"\n{new string('-', 90)}\n";
            var process = Process.GetCurrentProcess();

            Console.WriteLine(header, Color.FromArgb(65, 209, 209));
            Console.WriteLine(lineBreak, Color.FromArgb(128, 240, 227));
            Console.Write("     Runtime: ", Color.FromArgb(163, 75, 163));
            Console.Write($"{RuntimeInformation.FrameworkDescription}\n");
            Console.Write("     Process: ", Color.FromArgb(163, 75, 163));
            Console.Write($"{process.Id} ID | {process.Threads.Count} Threads\n");
            Console.Write("          OS: ", Color.FromArgb(163, 75, 163));
            Console.Write($"{RuntimeInformation.OSDescription} | {RuntimeInformation.ProcessArchitecture}\n");
            Console.WriteLine(lineBreak, Color.FromArgb(128, 240, 227));
        }

    }
}
