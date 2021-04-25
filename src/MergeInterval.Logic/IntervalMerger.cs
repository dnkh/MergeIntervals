using System;
using System.Collections.Generic;
using System.Linq;

namespace MergeInterval.Logic
{
    /// <summary>
    /// The class IntervalMerger is responsible to merge a list of intervals and return the merged list of intervals.
    /// </summary>

    public class IntervalMerger
    {
        /// <summary>
        /// This merge function expects a list of generic intervals, where the type of interval has to implement the interface IComparable to make sure that comparison between
        /// intervals is possible,
        /// The strategy of this merge function is to first sort the list of intervals by the start value, the check if bounds of the next interval are inside or outside of the current
        /// interval.
        /// To be fast and memory efficentcy the merge function uses yield to avoid first building up a local list of merged intervals and after that returnig this list.
        /// 
        /// </summary>
        /// <param name="intervals">A list of intervals with value type T</param>
        /// <returns>A list of merged intervals with value type T</returns>
        public static IEnumerable<Interval<T>> Merge<T>(IEnumerable<Interval<T>> intervals) where T : IComparable<T>
        {
            if(intervals == null) yield break;

            Interval<T> mergedInterval = null;

            foreach (var interval in intervals.OrderBy(_ => _.StartOfInterval))
            {
                if (mergedInterval == null)
                {
                    mergedInterval = interval;
                    continue;
                }

                if (mergedInterval.EndOfInterval.CompareTo(interval.StartOfInterval) < 0)
                {
                    yield return mergedInterval;
                    mergedInterval = interval;
                    continue;
                }

                if (mergedInterval.EndOfInterval.CompareTo(interval.EndOfInterval) < 0)
                {
                    mergedInterval = Interval<T>.Create(mergedInterval.StartOfInterval, interval.EndOfInterval);
                }
            }

            if(mergedInterval != null) yield return mergedInterval;
        }

    }


}

