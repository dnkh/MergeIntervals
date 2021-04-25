using System;
using CommandLine;

namespace MergeInterval
{
    /// <summary>
    /// Class to configure the command line parser
    /// More information can bei found at https://github.com/commandlineparser/commandline
    /// </summary>
    public class CommandLineOptions
    {
        [Option('c', "csv", Required = false, Group= "IntervalSource", HelpText = "Read intervals from the specified cvs file.Caution filename has to be enclosed with quotation marks")]
        public string CSVFile { get; set; }
         
        [Option('s', "string", Required = false, Group= "IntervalSource", HelpText = "Read intervals the command line.Caution intervals have to be enclosed with quotation marks E.g.: \"[25,30] [2,19] [14, 23] [4,8]\".")]
        public string IntervalString { get; set; }
    }
}