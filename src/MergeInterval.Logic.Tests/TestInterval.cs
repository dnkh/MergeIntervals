using System;
using System.Linq;
using System.Collections.Generic;
using MergeInterval.Logic;

using NUnit.Framework;


namespace MergeInterval.Logic.Tests
{
    public class TestInterval
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_For_Create_Interval_25_30()
        {
            //act
            var interval = Interval<int>.Create(25,30);
               
            //assert
            Assert.That( 25, Is.EqualTo(interval.StartOfInterval));
            Assert.That( 30, Is.EqualTo(interval.EndOfInterval));
        }


        [Test]
        public void Test_For_No_Exception_When_StartOfInterval_Smaller_Than_EndOfInterval()
        {
            //act
            var interval = Interval<int>.Create(25,30);
               
            //assert
            Assert.That( 25, Is.EqualTo(interval.StartOfInterval));
            Assert.That( 30, Is.EqualTo(interval.EndOfInterval));
        }

        [Test]
        public void Test_For_ArgumentException_When_StartOfInterval_Greater_Than_EndOfInterval()
        {
            //assert
            var ex = Assert.Throws<ArgumentException>(() => Interval<int>.Create(30,25));
        }

        [Test]
        public void Test_For_ArgumentException_When_StartOfInterval_Equal_EndOfInterval()
        {
            //assert
            var ex = Assert.Throws<ArgumentException>(() => Interval<int>.Create(25,25));
        }

    }
}