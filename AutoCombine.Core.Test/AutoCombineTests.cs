using System;
using Xunit;
using AutoCombine.Core.Test.Models;
using System.Collections.Generic;
using System.Linq;

namespace AutoCombine.Core.Test
{
    public class AutoCombineTests
    {
        private AutoCombine combiner;
        private IEnumerable<Values> items;
        public AutoCombineTests()
        {
            combiner = new AutoCombine();
            items = combiner.Combine<Values>();
        }

        [Fact]
        public void DefaultValueTypesWork()
        {
            Assert.True(items.Any());
        }

        [Fact]
        public void BoolCombinerWorks()
        {
            var expected = new bool[] { false, true };
            var bools = items.Select(x => x.Boolean).Distinct();
            Assert.True(bools.SequenceEqual(expected));
        }
    }
}
