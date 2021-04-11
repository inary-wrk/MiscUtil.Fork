using System.Collections.Generic;
using NUnit.Framework;
using Moq;

namespace MiscUtil.UnitTests
{
    [TestFixture]
    public class PartialComparerTest
    {
        #region ReferenceCompare
        [Test]
        public void EqualNonNullReferencesReturnZero()
        {
            Assert.AreEqual(0, PartialComparer.ReferenceCompare("x", "x").Value);
        }

        [Test]
        public void TwoNullReferencesReturnZero()
        {
            Assert.AreEqual(0, PartialComparer.ReferenceCompare<string>(null, null).Value);
        }

        [Test]
        public void NullLessThanNonNull()
        {
            Assert.AreEqual(-1, PartialComparer.ReferenceCompare(null, "x").Value);
        }

        [Test]
        public void NonNullGreaterThanNull()
        {
            Assert.AreEqual(1, PartialComparer.ReferenceCompare("x", null).Value);
        }

        [Test]
        public void DifferentNonNullReferencesReturnNull()
        {
            // Just to be extra careful, make two different references to equal strings.
            // That way we know we're not actually doing comparisons!
            string x1 = new string(new []{ 'x' });
            string x2 = new string(new []{ 'x' });
            Assert.AreNotSame(x1, x2);
            Assert.IsNull(PartialComparer.ReferenceCompare(x1, x2));
        }
        #endregion

        #region Compare
        [Test]
        public void DefaultLessThanReturnsLessThanZero()
        {
            Assert.IsTrue(PartialComparer.Compare(3, 5) < 0);
        }

        [Test]
        public void DefaultGreaterThanReturnsGreaterThanZero()
        {
            Assert.IsTrue(PartialComparer.Compare(5, 3) > 0);
        }

        [Test]
        public void DefaultEqualReturnsNull()
        {
            Assert.IsNull(PartialComparer.Compare(4, 4));
        }

        [Test]
        public void CompareReturnsNullWhenSpecifiedComparerReturnsNonZero()
        {
            var mocks = new Mock<IComparer<string>>();

            mocks.Setup(x => x.Compare("first", "second")).Returns(15).Verifiable();

            Assert.AreEqual(15, PartialComparer.Compare(mocks.Object, "first", "second").Value);

            mocks.VerifyAll();
        }

        [Test]
        public void CompareReturnsNullWhenSpecifiedComparerReturnsZero()
        {
            var mocks = new Mock<IComparer<string>>();

            mocks.Setup(x => x.Compare("first", "second")).Returns(0).Verifiable();

            Assert.IsNull(PartialComparer.Compare(mocks.Object, "first", "second"));
            mocks.VerifyAll();
        }
        #endregion

        #region Equals
        [Test]
        public void TwoNullReferencesAreEqual()
        {
            Assert.IsTrue(PartialComparer.Equals<string>(null, null).Value);
        }

        [Test]
        public void NullAndNonNullAreUnequal()
        {
            Assert.IsFalse(PartialComparer.Equals<string>(null, "non-null").Value);
        }

        [Test]
        public void NonNullAndNullAreUnequal()
        {
            Assert.IsFalse(PartialComparer.Equals("non-null", null).Value);
        }

        [Test]
        public void DifferentNonNullReferencesReturnMaybe()
        {
            Assert.IsNull(PartialComparer.Equals("first", "second"));
        }
        #endregion
    }
}
