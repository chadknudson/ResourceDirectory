using CommandLine;

namespace ResourceDirectory
{
    public class Options
    {
        [Option('f', "file", Required = true, HelpText = "Full path and filename of the file containing the resources.")]
        public string FilePath { get; set; }
    }
}
