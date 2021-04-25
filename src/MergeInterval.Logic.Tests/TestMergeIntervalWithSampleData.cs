using System;
using System.Linq;
using System.Collections.Generic;
using MergeInterval.Logic;

using NUnit.Framework;


namespace MergeInterval.Logic.Tests
{
    public class TestMergeIntervalWithSampleData
    {

        private List<Interval<int>> _testIntervals = null;

        [SetUp]
        public void Setup()
        {
            _testIntervals = new List<Interval<int>>();

            _testIntervals.Add(Interval<int>.Create(25,30));
            _testIntervals.Add(Interval<int>.Create(2,19));
            _testIntervals.Add(Interval<int>.Create(14,23));
            _testIntervals.Add(Interval<int>.Create(4,8));
        }

        [Test]
        public void Test_For_2_Merged_Intervals()
        {
            //arrange
            List<Interval<int>> localIntervals = _testIntervals;
            
            //act
            var mergedIntervals = IntervalMerger.Merge<int>(localIntervals);
            
            //assert
            Assert.That(  2, Is.EqualTo(mergedIntervals.Count()));
        }

        [Test]
        public void Test_For_Interval_2_23()
        {
            //arrange
            List<Interval<int>> localIntervals = _testIntervals;
            
            //act
            var mergedIntervals = IntervalMerger.Merge<int>(localIntervals);
            
            //assert
            Assert.That(  2, Is.EqualTo(mergedIntervals.ElementAt(0).StartOfInterval));
            Assert.That( 23, Is.EqualTo(mergedIntervals.ElementAt(0).EndOfInterval));
        }
        [Test]
        public void Test_For_Interval_25_30()
        {
            //arrange
            List<Interval<int>> localIntervals = _testIntervals;
            
            //act
            var mergedIntervals = IntervalMerger.Merge<int>(localIntervals);
            
            //assert
            Assert.That( 25, Is.EqualTo(mergedIntervals.ElementAt(1).StartOfInterval));
            Assert.That( 30, Is.EqualTo(mergedIntervals.ElementAt(1).EndOfInterval));
        }
    }
}