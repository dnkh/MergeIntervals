using System;
using System.Collections.Generic;
using System.Linq;
using MergeInterval.Logic;
using CommandLine;
using System.Diagnostics;

namespace MergeInterval
{

    /// <summary>
    /// This is a program to merge intervals sequences and output the resulting interval list on the command line
    /// The source list of intervals can be a string of intervals like "[25,30] [2,19] [14, 23] [4,8]" or it can be
    /// a cvs file where each line in the file is an interval. Start and end value is separated by a semicolon
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //parse command line args and call the "Run" method
             Parser.Default.ParseArguments<CommandLineOptions>(args)
                .WithParsed(Run);
        }
        private static void Run(CommandLineOptions opts)
        {
            try
            {
                var sourceIntervals = ReadIntIntervals(opts);

                var mergedIntervals = IntervalMerger.Merge<int>(sourceIntervals);

                IntervalWriter.WriteToConsole(mergedIntervals);
            }
            catch( Exception ex)
            {
                System.Console.WriteLine($"An execption occured:{ex.Message}");
            }
        }

        /// <summary>
        /// Create a list of int intervals. The source of the intervals depends on the command line options
        /// </summary>
        private static IEnumerable<Interval<int>> ReadIntIntervals(CommandLineOptions options)
        {
            if( !String.IsNullOrEmpty(options.CSVFile))
            {
                return IntervalReader.ReadFromCSVFileAsInt(options.CSVFile);
            }

            if( !String.IsNullOrEmpty(options.IntervalString))
            {
                return IntervalReader.ReadFromStringAsInt(options.IntervalString);
            }

            return IntervalReader.ReadFromStringAsInt(@"[25,30] [2,19] [14, 23] [4,8]");
        }
    }
}
