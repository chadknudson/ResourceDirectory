using CommandLine;
using System.Reflection;

namespace ResourceDirectory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
            .WithParsed<Options>(o =>
            {
                if (File.Exists(o.FilePath))
                {
                    ResourceDirectory(o.FilePath);
                }
                else
                {
                    Console.WriteLine($"The source file {o.FilePath} was not located.");
                }
            });
        }

        public static void ResourceDirectory(string dllPath)
        {           
            var asm = Assembly.LoadFrom(dllPath);
            string[] strings = asm.GetManifestResourceNames();
            foreach (var s in strings)
            {
                Console.WriteLine(s);
            }
        }
    }
}
