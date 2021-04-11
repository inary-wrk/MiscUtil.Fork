using System;

using MiscUtil.Linq;
using MiscUtil.Linq.Extensions;
using NUnit.Framework;

namespace MiscUtil.UnitTests.Linq.Extensions
{
    public partial class DataProducerExtTest
    {
        [Test]
        public void SimpleCountWithNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.Count());
        }

        [Test]
        public void ConditionalCountWithNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.Count(x => x.Length == 0));
        }

        [Test]
        public void ConditionalCountWithNullCondition()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.Count(null));
        }

        [Test]
        public void SimpleLongCountWithNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.LongCount());
        }

        [Test]
        public void ConditionalLongCountWithNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.LongCount(x => x.Length == 0));
        }

        [Test]
        public void ConditionalLongCountWithNullCondition()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.LongCount(null));
        }

        [Test]
        public void SimpleFirstWithNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.First());
        }

        [Test]
        public void ConditionalFirstWithNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.First(x => x.Length == 0));
        }

        [Test]
        public void ConditionalFirstWithNullCondition()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.First(null));
        }

        [Test]
        public void SimpleLastWithNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.Last());
        }

        [Test]
        public void ConditionalLastWithNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.Last(x => x.Length == 0));
        }

        [Test]
        public void ConditionalLastWithNullCondition()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.Last(null));
        }

        [Test]
        public void SimpleFirstOrDefaultWithNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.FirstOrDefault());
        }

        [Test]
        public void ConditionalFirstOrDefaultWithNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.FirstOrDefault(x => x.Length == 0));
        }

        [Test]
        public void ConditionalFirstOrDefaultWithNullCondition()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.FirstOrDefault(null));
        }

        [Test]
        public void SimpleLastOrDefaultWithNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.LastOrDefault());
        }

        [Test]
        public void ConditionalLastOrDefaultWithNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.LastOrDefault(x => x.Length == 0));
        }

        [Test]
        public void ConditionalLastOrDefaultWithNullCondition()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.LastOrDefault(null));
        }

        [Test]
        public void SimpleSingleWithNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.Single());
        }

        [Test]
        public void ConditionalSingleWithNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.Single(x => x.Length == 0));
        }

        [Test]
        public void ConditionalSingleWithNullCondition()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.Single(null));
        }

        [Test]
        public void SimpleSingleOrDefaultWithNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.SingleOrDefault());
        }

        [Test]
        public void ConditionalSingleOrDefaultWithNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.SingleOrDefault(x => x.Length == 0));
        }

        [Test]
        public void ConditionalSingleOrDefaultWithNullCondition()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.SingleOrDefault(null));
        }

        [Test]
        public void ElementAtWithNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.ElementAt(0));
        }

        [Test]
        public void ElementAtOrDefaultWithNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.ElementAtOrDefault(0));
        }

        [Test]
        public void ElementAtWithNegativeIndex()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => NonNullDataProducer.ElementAt(-1));
        }

        [Test]
        public void ElementAtOrDefaultWithNegativeIndex()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => NonNullDataProducer.ElementAtOrDefault(-1));
        }

        [Test]
        public void AllWithNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.All(x => x.Length == 0));
        }

        [Test]
        public void AllWithNullCondition()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.All(null));
        }

        [Test]
        public void SimpleAnyWithNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.Any());
        }

        [Test]
        public void ConditionalAnyWithNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.Any(x => x.Length == 0));
        }

        [Test]
        public void ConditionalAnyWithNullCondition()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.Any(null));
        }

        [Test]
        public void SimpleContainsWithNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.Contains("x"));
        }

        [Test]
        public void ComparerSpecifiedContainsWithNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.Contains("x", StringComparer.CurrentCulture));
        }

        [Test]
        public void ComparerSpecifiedContainsWithNullCondition()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.Contains("x", null));
        }

        [Test]
        public void SimpleAggregateWithNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.Aggregate((x, y) => x + y));
        }

        [Test]
        public void SimpleAggregateWithNullAggregation()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.Aggregate(null));
        }

        [Test]
        public void SeededAggregateWithNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.Aggregate("", (x, y) => x + y));
        }

        [Test]
        public void SeededAggregateWithNullAggregation()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.Aggregate("", null));
        }

        [Test]
        public void SeededProjectionAggregateWithNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.Aggregate("", (x, y) => x + y, x => x));
        }

        [Test]
        public void SeededProjectionAggregateWithNullAggregation()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.Aggregate("", null, x => x));
        }

        [Test]
        public void SeededProjectionAggregateWithNullProjection()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.Aggregate<string, string, string>("", (x, y) => x + y, null));
        }

#if DOTNET35
        [Test]
        public void SimpleSumWithNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.Sum());
        }

        [Test]
        public void ProjectedSumWithNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.Sum(x => x.Length));
        }

        [Test]
        public void ProjectedSumWithNullProjection()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.Sum<string, string>(null));
        }

        [Test]
        public void SimpleAverageWithNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.Average());

        }

        [Test]
        public void ProjectedAverageWithNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.Average(x => x));
        }

        [Test]
        public void ProjectedAverageWithNullProjection()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.Average<string, string>(null));
        }
#endif
        [Test]
        public void SimpleMaxWithNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.Max());
        }

        [Test]
        public void ProjectedMaxWithNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.Max(x => x.Length));
        }

        [Test]
        public void ProjectedMaxWithNullProjection()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.Max<string, string>(null));
        }

        [Test]
        public void SimpleMinWithNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.Min());
        }

        [Test]
        public void ProjectedMinWithNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.Min(x => x.Length));
        }

        [Test]
        public void ProjectedMinWithNullProjection()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.Min<string, string>(null));
        }

        [Test]
        public void GroupByNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.GroupBy(x => x, x => x, (x, y) => x, StringComparer.CurrentCulture));
        }

        [Test]
        public void GroupByNullKeySelector()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.GroupBy(null, x => x, (x, y) => x, StringComparer.CurrentCulture));
        }

        [Test]
        public void GroupByNullElementSelector()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.GroupBy<string, string, string, string>(x => x, null, (x, y) => x, StringComparer.CurrentCulture));
        }

        [Test]
        public void GroupByNullResultSelector()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.GroupBy<string, string, string, string>(x => x, x => x, null, StringComparer.CurrentCulture));
        }

        [Test]
        public void GroupByNullComparer()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.GroupBy(x => x, x => x, (x, y) => x, null));
        }

        [Test]
        public void SimpleSelectNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.Select(x => x));
        }

        [Test]
        public void SimpleSelectNullProjection()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.Select((Func<string, string>)null));
        }

        [Test]
        public void SelectWithIndexNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.Select((x, i) => x));
        }

        [Test]
        public void SelectWithIndexNullProjection()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.Select((Func<string, int, string>)null));
        }

        [Test]
        public void SimpleWhereNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.Where(x => x.Length == 0));
        }

        [Test]
        public void SimpleWhereNullProjection()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.Where((Func<string, bool>)null));
        }

        [Test]
        public void WhereWithIndexNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.Where((x, i) => false));
        }

        [Test]
        public void WhereWithIndexNullProjection()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.Where((Func<string, int, bool>)null));
        }

        [Test]
        public void SimpleDefaultIfEmptyNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.DefaultIfEmpty());
        }

        [Test]
        public void DefaultIfEmptyWithDefaultNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.DefaultIfEmpty(""));
        }

        [Test]
        public void TakeNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.Take(1));
        }

        [Test]
        public void SimpleTakeWhileNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.TakeWhile(x => x.Length == 0));
        }

        [Test]
        public void SimpleTakeWhileNullCondition()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.TakeWhile((Func<string, bool>)null));
        }

        [Test]
        public void TakeWhileWithIndexNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.TakeWhile((x, i) => x.Length == 0));
        }

        [Test]
        public void TakeWhileWithIndexNullCondition()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.TakeWhile((Func<string, int, bool>)null));
        }

        [Test]
        public void SkipNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.Skip(1));
        }

        [Test]
        public void SimpleSkipWhileNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.SkipWhile(x => x.Length == 0));
        }

        [Test]
        public void SimpleSkipWhileNullCondition()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.SkipWhile((Func<string, bool>)null));
        }

        [Test]
        public void SkipWhileWithIndexNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.SkipWhile((x, i) => x.Length == 0));
        }

        [Test]
        public void SkipWhileWithIndexNullCondition()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.SkipWhile((Func<string, int, bool>)null));
        }

#if DOTNET35
        [Test]
        public void SimpleDistinctNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.Distinct());
        }

        [Test]
        public void DistinctWithComparerNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.Distinct(StringComparer.CurrentCulture));
        }

        [Test]
        public void DistinctWithComparerNullComparer()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.Distinct(null));
        }

        [Test]
        public void ReverseNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.Reverse());
        }

        [Test]
        public void OrderByNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.OrderBy(x => x, StringComparer.CurrentCulture));
        }

        [Test]
        public void OrderByNullSelector()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.OrderBy(null, StringComparer.CurrentCulture));
        }

        [Test]
        public void OrderByNullComparer()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.OrderBy(x => x, null));
        }

        [Test]
        public void ThenByNullSelector()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.OrderBy(x => x).ThenBy(null, StringComparer.CurrentCulture));
        }

        [Test]
        public void ThenByNullComparer()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.OrderBy(x => x).ThenBy(x => x, null));
        }
#endif

        [Test]
        public void AsFutureEnumerableNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.AsFutureEnumerable());
        }

        [Test]
        public void AsEnumerableNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.AsEnumerable());
        }

        [Test]
        public void ToListNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.ToList());
        }

        [Test]
        public void ToFutureArrayNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.ToFutureArray());
        }

        [Test]
        public void ToLookupNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.ToLookup(x => x, x => x, StringComparer.CurrentCulture));
        }

        [Test]
        public void ToLookupNullKeySelector()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.ToLookup(null, x => x, StringComparer.CurrentCulture));
        }

        [Test]
        public void ToLookupNullElementSelector()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.ToLookup(x => x, (Func<string, string>)null, StringComparer.CurrentCulture));
        }

        [Test]
        public void ToLookupNullComparer()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.ToLookup(x => x, x => x, null));
        }

        [Test]
        public void ToDictionaryNullSource()
        {
            Assert.Throws<ArgumentNullException>(() => NullDataProducer.ToDictionary(x => x, x => x, StringComparer.CurrentCulture));
        }

        [Test]
        public void ToDictionaryNullKeySelector()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.ToDictionary(null, x => x, StringComparer.CurrentCulture));
        }

        [Test]
        public void ToDictionaryNullElementSelector()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.ToDictionary(x => x, (Func<string, string>)null, StringComparer.CurrentCulture));
        }

        [Test]
        public void ToDictionaryNullComparer()
        {
            Assert.Throws<ArgumentNullException>(() => NonNullDataProducer.ToDictionary(x => x, x => x, null));
        }

        DataProducer<string> NullDataProducer
        {
            get { return null; }
        }

        DataProducer<string> NonNullDataProducer
        {
            get { return new DataProducer<string>(); }
        }
    }
}
