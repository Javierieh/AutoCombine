using System;
using Xunit;
using AutoCombine.Core.Test.Models;
using System.Collections.Generic;
using System.Linq;
using AutoCombine.Core.Test.Helpers;
namespace AutoCombine.Core.Test
{
    public class DefaultAutoCombinerTests
    {
        protected AutoCombine combiner;
        protected IEnumerable<Values> Items { get; set; }
        public DefaultAutoCombinerTests()
        {
            combiner = new AutoCombine();
            Items = combiner.Combine<Values>();
        }

        [Fact]
        public void DefaultValueTypesWork()
        {
            Assert.True(Items.Any());
        }

        [Fact]
        public void DefaultBoolCombinerWorks()
        {
            var expected = new HashSet<bool>{ false, true };
            var values = Items.GetDistinct(x => x.Boolean);
            Assert.True(expected.SetEquals(values));
        }

        [Fact]
        public void DefaultNullableBoolCombinerWorks()
        {
            var expected = new HashSet<bool?>{ false, true, null };
            var values = Items.GetDistinct(x => x.NullableBoolean);
            Assert.True(expected.SetEquals(values));
        }

        [Fact]
        public void DefaultByteCombinerWorks()
        {
            var expected = new HashSet<byte> { byte.MinValue, byte.MaxValue };
            var values = Items.GetDistinct(x => x.Byte);
            Assert.True(expected.SetEquals(values));
        }

        [Fact]
        public void DefaultNullableByteCombinerWorks()
        {
            var expected = new HashSet<byte?> { byte.MinValue, byte.MaxValue, null };
            var values = Items.GetDistinct(x => x.NullableByte);
            Assert.True(expected.SetEquals(values));
        }

        [Fact]
        public void DefaultCharCombinerWorks()
        {
            var expected = new HashSet<char> { char.MinValue, char.MaxValue };
            var values = Items.GetDistinct(x => x.Char);
            Assert.True(expected.SetEquals(values));
        }

        [Fact]
        public void DefaultNullableCharCombinerWorks()
        {
            var expected = new HashSet<char?> { char.MinValue, char.MaxValue, null };
            var values = Items.GetDistinct(x => x.NullableChar);
            Assert.True(expected.SetEquals(values));
        }

        [Fact]
        public void DefaultDecimalCombinerWorks()
        {
            var expected = new HashSet<decimal> { decimal.MinValue, decimal.MinusOne, (decimal)0, decimal.One, decimal.MaxValue };
            var values = Items.GetDistinct(x => x.Decimal);
            Assert.True(expected.SetEquals(values));
        }

        [Fact]
        public void DefaultNullableDecimalCombinerWorks()
        {
            var expected = new HashSet<decimal?> { decimal.MinValue, decimal.MinusOne, (decimal)0, decimal.One, decimal.MaxValue, null };
            var values = Items.GetDistinct(x => x.NullableDecimal);
            Assert.True(expected.SetEquals(values));
        }

        [Fact]
        public void DefaultDoubleCombinerWorks()
        {
            var expected = new HashSet<double> { double.NegativeInfinity, double.MinValue, (double)0, double.MaxValue, double.PositiveInfinity, double.NaN };
            var values = Items.GetDistinct(x => x.Double);
            Assert.True(expected.SetEquals(values));
        }

        [Fact]
        public void DefaultNullableDoubleCombinerWorks()
        {
            var expected = new HashSet<double?> { double.NegativeInfinity, double.MinValue, (double)0, double.MaxValue, double.PositiveInfinity, double.NaN, null };
            var values = Items.GetDistinct(x => x.NullableDouble);
            Assert.True(expected.SetEquals(values));
        }

        [Fact]
        public void DefaultFloatCombinerWorks()
        {
            var expected = new HashSet<float> { float.NegativeInfinity, float.MinValue, (float)0, float.MaxValue, float.PositiveInfinity, float.NaN };
            var values = Items.GetDistinct(x => x.Float);
            Assert.True(expected.SetEquals(values));
        }

        [Fact]
        public void DefaultNullableFloatCombinerWorks()
        {
            var expected = new HashSet<float?> { float.NegativeInfinity, float.MinValue, (float)0, float.MaxValue, float.PositiveInfinity, float.NaN, null };
            var values = Items.GetDistinct(x => x.NullableFloat);
            Assert.True(expected.SetEquals(values));
        }

        [Fact]
        public void DefaultIntCombinerWorks()
        {
            var expected = new HashSet<int> { int.MinValue, -1, 0, 1, int.MaxValue };
            var values = Items.GetDistinct(x => x.Integer);
            Assert.True(expected.SetEquals(values));
        }

        [Fact]
        public void DefaultNullableIntCombinerWorks()
        {
            var expected = new HashSet<int?> { int.MinValue, -1, 0, 1, int.MaxValue, null };
            var values = Items.GetDistinct(x => x.NullableInteger);
            Assert.True(expected.SetEquals(values));
        }

        [Fact]
        public void DefaultLongCombinerWorks()
        {
            var expected = new HashSet<long> { long.MinValue, (long)0, long.MaxValue };
            var values = Items.GetDistinct(x => x.Long);
            Assert.True(expected.SetEquals(values));
        }

        [Fact]
        public void DefaultNullableLongCombinerWorks()
        {
            var expected = new HashSet<long?> { long.MinValue, (long)0, long.MaxValue, null };
            var values = Items.GetDistinct(x => x.NullableLong);
            Assert.True(expected.SetEquals(values));
        }

        [Fact]
        public void DefaultSByteCombinerWorks()
        {
            var expected = new HashSet<sbyte> { sbyte.MinValue, (sbyte)0, sbyte.MaxValue };
            var values = Items.GetDistinct(x => x.SByte);
            Assert.True(expected.SetEquals(values));
        }

        [Fact]
        public void DefaultNullableSByteCombinerWorks()
        {
            var expected = new HashSet<sbyte?> { sbyte.MinValue, (sbyte)0, sbyte.MaxValue, null };
            var values = Items.GetDistinct(x => x.NullableSByte);
            Assert.True(expected.SetEquals(values));
        }

        [Fact]
        public void DefaultShortCombinerWorks()
        {
            var expected = new HashSet<short> { short.MinValue, (short)0, short.MaxValue };
            var values = Items.GetDistinct(x => x.Short);
            Assert.True(expected.SetEquals(values));
        }

        [Fact]
        public void DefaultNullableShortCombinerWorks()
        {
            var expected = new HashSet<short?> { short.MinValue, (short)0, short.MaxValue, null };
            var values = Items.GetDistinct(x => x.NullableShort);
            Assert.True(expected.SetEquals(values));
        }

        [Fact]
        public void DefaultUIntCombinerWorks()
        {
            var expected = new HashSet<uint> { uint.MinValue, uint.MaxValue };
            var values = Items.GetDistinct(x => x.UInt);
            Assert.True(expected.SetEquals(values));
        }

        [Fact]
        public void DefaultNullableUIntCombinerWorks()
        {
            var expected = new HashSet<uint?> { uint.MinValue, uint.MaxValue, null };
            var values = Items.GetDistinct(x => x.NullableUInt);
            Assert.True(expected.SetEquals(values));
        }

        [Fact]
        public void DefaultULongCombinerWorks()
        {
            var expected = new HashSet<ulong> { ulong.MinValue, ulong.MaxValue };
            var values = Items.GetDistinct(x => x.ULong);
            Assert.True(expected.SetEquals(values));
        }

        [Fact]
        public void DefaultNullableULongCombinerWorks()
        {
            var expected = new HashSet<ulong?> { ulong.MinValue, ulong.MaxValue, null };
            var values = Items.GetDistinct(x => x.NullableULong);
            Assert.True(expected.SetEquals(values));
        }

        [Fact]
        public void DefaultUShortCombinerWorks()
        {
            var expected = new HashSet<ushort> { ushort.MinValue, ushort.MaxValue };
            var values = Items.GetDistinct(x => x.UShort);
            Assert.True(expected.SetEquals(values));
        }

        [Fact]
        public void DefaultNullableUShortCombinerWorks()
        {
            var expected = new HashSet<ushort?> { ushort.MinValue, ushort.MaxValue, null };
            var values = Items.GetDistinct(x => x.NullableUShort);
            Assert.True(expected.SetEquals(values));
        }

        [Fact]
        public void DefaultStringCombinerWorks()
        {
            var expected = new HashSet<string> { "", "aString", null };
            var values = Items.GetDistinct(x => x.String);
            Assert.True(expected.SetEquals(values));
        }

        [Fact]
        public void DefaultEnumCombinerWorks()
        {
            var expected = new HashSet<EnumValue> { EnumValue.MinusOne, EnumValue.Zero, EnumValue.One };
            var values = Items.GetDistinct(x => x.EnumValue);
            Assert.True(expected.SetEquals(values));
        }

        [Fact]
        public void DefaultNullableEnumCombinerWorks()
        {
            var expected = new HashSet<EnumValue?> { EnumValue.MinusOne, EnumValue.Zero, EnumValue.One, null};
            var values = Items.GetDistinct(x => x.NullableEnumValue);
            Assert.True(expected.SetEquals(values));
        }
    }
}
