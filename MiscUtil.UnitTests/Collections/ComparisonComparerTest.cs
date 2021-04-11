using System;
using System.Collections.Generic;
using MiscUtil.Collections;
using NUnit.Framework;
using Moq;

namespace MiscUtil.UnitTests.Collections
{
    [TestFixture]
    public class ComparisonComparerTest
    {
        [Test]
        public void ConstructionWithNull()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                new ComparisonComparer<string>(null);
            });
        }

        [Test]
        public void CreateComparisonWithNull()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                ComparisonComparer<string>.CreateComparison(null);
            });
        }

        [Test]
        public void CreateAndCall()
        {
            var mocks = new Mock<Comparison<string>>();
            mocks.Setup(x => x("hello", "there")).Returns(5).Verifiable();
            mocks.Setup(x => x("x", "y")).Returns(-3).Verifiable();
            Exception exception = new Exception();
            mocks.Setup(x => x("throw", "exception")).Throws(exception).Verifiable();
            
            IComparer<string> comparer = new ComparisonComparer<string>(mocks.Object);
            Assert.AreEqual(5, comparer.Compare("hello", "there"));
            Assert.AreEqual(-3, comparer.Compare("x", "y"));
            try
            {
                comparer.Compare("throw", "exception");
                Assert.Fail("Expected exception");
            }
            catch (Exception e)
            {
                Assert.AreSame(exception, e);
            }
            mocks.VerifyAll();
        }

        [Test]
        public void CreateAndCallComparsison()
        {
            var mocks = new Mock<IComparer<string>>();

            mocks.Setup(x => x.Compare("hello", "there")).Returns(5).Verifiable();
            mocks.Setup(x => x.Compare("x", "y")).Returns(-3).Verifiable();
            Exception exception = new Exception();
            mocks.Setup(x => x.Compare("throw", "exception")).Throws(exception).Verifiable();


            Comparison<string> comparison = ComparisonComparer<string>.CreateComparison(mocks.Object);
            Assert.AreEqual(5, comparison("hello", "there"));
            Assert.AreEqual(-3, comparison("x", "y"));
            try
            {
                comparison("throw", "exception");
                Assert.Fail("Expected exception");
            }
            catch (Exception e)
            {
                Assert.AreSame(exception, e);
            }
            mocks.VerifyAll();
        }
    }
}
