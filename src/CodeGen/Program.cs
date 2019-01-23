using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CodeGen
{
    class Program
    {
        private static readonly string[] Methods = {"Delete", "Get", "Post", "Put"};

        static async Task Main(string[] args)
        {
            if (args.Length != 1 || !int.TryParse(args[0], out int maxArgs))
            {
                Console.Error.WriteLine("Usage: dotnet run - [maxArgs]");
                return;
            }

            await GenerateVerbMethods(maxArgs);
            await GenerateConvenienceMethods(maxArgs);
        }

        private static async Task GenerateVerbMethods(int maxArgs)
        {
                using (var writer = File.CreateText($"../RendleLabs.AspNetCore.RoutingWithServices/RouteBuilderMapVerbExtensions.cs"))
                {
                    await writer.WriteLineAsync(VerbTemplate.FileStart);
                    for (int i = 1; i <= maxArgs; i++)
                    {
                        var typeParams = string.Join(", ", Enumerable.Range(1, i).Select(n => $"T{n}"));
                        await writer.WriteLineAsync(VerbTemplate.MethodStart.Replace("{TypeParams}", typeParams));
                        for (int n = 1; n <= i; n++)
                        {
                            await writer.WriteLineAsync(VerbTemplate.GetRequiredService.Replace("{Number}", n.ToString()));
                        }

                        var dependencies = string.Join(", ", Enumerable.Range(1, i).Select(n => $"d{n}"));
                        await writer.WriteLineAsync(VerbTemplate.MethodEnd.Replace("{Dependencies}", dependencies));
                    }

                    await writer.WriteLineAsync(VerbTemplate.FileEnd);
                }
        }
        private static async Task GenerateConvenienceMethods(int maxArgs)
        {
            foreach (var method in Methods)
            {
                using (var writer = File.CreateText($"../RendleLabs.AspNetCore.RoutingWithServices/RouteBuilderMap{method}Extensions.cs"))
                {
                    await writer.WriteLineAsync(ConvenienceTemplate.FileStart.Replace("{Method}", method));
                    for (int i = 1; i <= maxArgs; i++)
                    {
                        var typeParams = string.Join(", ", Enumerable.Range(1, i).Select(n => $"T{n}"));
                        var methodDeclaration = ConvenienceTemplate.Method
                            .Replace("{Method}", method)
                            .Replace("{Verb}", method.ToUpperInvariant())
                            .Replace("{TypeParams}", typeParams);
                        await writer.WriteLineAsync(methodDeclaration);
                    }

                    await writer.WriteLineAsync(ConvenienceTemplate.FileEnd);
                }
            }
        }
    }
}