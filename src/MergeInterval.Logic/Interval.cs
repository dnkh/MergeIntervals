using System;


namespace MergeInterval.Logic
{

    /// <summary>
    /// This class represents a generic interval. It requires only that the data type implements the interface IComparable.
    /// The constructor and the setter of StartOfInterval and EndOfInterval are private to make sure that the EndOfInterval is
    /// always greater than StartOfInterval
    /// To create an interval, do the "greater" check and avoid throwing an exception inside the constructor the class has a static "Create" method.
    /// </summary>
    public class Interval<T> where T: IComparable<T>
    {
        private Interval(T startOfInterval,T endOfInterval)
        {
            StartOfInterval = startOfInterval;
            EndOfInterval= endOfInterval;
        }
        public T StartOfInterval { get; private set; }
        public T EndOfInterval { get; private set;} 

        public static Interval<T> Create(T startOfInterval, T endOfInterval ) 
        {
             if( startOfInterval.CompareTo(endOfInterval) < 0 )
             {
                return new Interval<T>(startOfInterval, endOfInterval);
             }
             else
             {
                throw new ArgumentException($"{nameof(endOfInterval)} has to be greater than {nameof(endOfInterval)}");
             } 
        }  
        
    }
}