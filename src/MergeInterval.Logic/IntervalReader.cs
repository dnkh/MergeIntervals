using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;


namespace MergeInterval.Logic
{
    /// <summary>
    /// This class is responsible for creating a list of intervals from a cvs file or from a string
    /// </summary>
    public class IntervalReader
    {
        /// <summary>
        /// This function reads a cvs file and creates a list of intervals with value type int
        /// The expected format of the cvs file is:
        ///     one line for each interval. Start and end value of the interval is separated by a semicolon
        /// </summary>
        /// <param name="fileName">Full path to the csv file</param>
        /// <returns>A list of intervals with value type int</returns>
        public static IEnumerable<Interval<int>> ReadFromCSVFileAsInt(string fileName)
        {
            using(var reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    if(values.Length > 1)
                    {
                        yield return Interval<int>.Create( int.Parse(values[0]), int.Parse(values[1]));
                    }
                }
            }
        }
        /// <summary>
        /// This function extracts the intervals out of string and creates a list of intervals with value type int
        /// To extract the intervals, it's using a regular expression.
        /// The expected content of the interval string is:
        ///     - each interval is inside square brackets
        ///     - start and end value is separated with a colon
        ///     - intervals can be separated by a space 
        ///     - e.g "[25,30] [2,19] [14, 23] [4,8]"
        /// </summary>
        /// <param name="intervalsString"></param>
        /// <returns>A list of intervals with value type int</returns>
        public static IEnumerable<Interval<int>> ReadFromStringAsInt(string intervalsString)
        {
            const string regExPattern = @"\[(?<Start>\d+) *, *(?<End>\d+) *\]";

	        Regex regex = new Regex(regExPattern);
	        MatchCollection matches = regex.Matches(intervalsString);

            foreach (Match match in matches)
            {
                GroupCollection groups = match.Groups;
                
                yield return Interval<int>.Create(
                                            int.Parse(groups["Start"].Value),
                                            int.Parse(groups["End"].Value));
                 
            }
        }
    }
}