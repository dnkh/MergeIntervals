using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;


namespace MergeInterval.Logic
{
    /// <summary>
    /// This class is responsible for writing / ouput  a list of intervals
    /// </summary>
    public class IntervalWriter
    {
        /// <summary>
        /// This functions writes the list of generic intervals to the console in the following format
        ///     - one line for each interval
        ///     - start and end value are inside square brackets and separated with a colon
        /// </summary>
        /// <param name="intervals">A list of intervals with value type T</param>
        public static void WriteToConsole<T>(IEnumerable<Interval<T>> intervals ) where T: IComparable<T> 
        {
            foreach(var interval in intervals)
            {
                System.Console.WriteLine($"[{interval.StartOfInterval},{interval.EndOfInterval}]");
            }
        }
    }
}