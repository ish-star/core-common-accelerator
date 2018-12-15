using NxtLvl.Core.Common.StringExtensions;
using System;
using Xunit;

namespace NxtLvl.Core.Common.Tests
{
    public class StringExtensionsTests
    {
        [Theory]
        [InlineData(null, true)]
        [InlineData("", true)]
        [InlineData(" ", true)]
        [InlineData("val", false)]
        public void StringExtensions_IsNullOrWhiteSpace(string value, bool expected)
        {
            var actual = value.IsNullOrWhiteSpace();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(null, null, null, (short)0, null)]
        [InlineData("", null, null, (short)0, null)]
        [InlineData(" ", null, null, (short)0, null)]
        [InlineData(null, (short)1, null, (short)1, null)]
        [InlineData("", (short)1, null, (short)1, null)]
        [InlineData(" ", (short)1, null, (short)1, null)]
        [InlineData(null, null, true, (short)0, null)]
        [InlineData("", null, true, (short)0, null)]
        [InlineData(" ", null, true, (short)0, null)]
        [InlineData("1", null, null, (short)1, null)]
        [InlineData("-1", null, null, (short)-1, null)]
        [InlineData("0", null, null, (short)0, null)]
        [InlineData("32767", null, null, short.MaxValue, null)]
        [InlineData("-32768", null, null, short.MinValue, null)]
        [InlineData("32768", null, null, null, true)]
        [InlineData("-32769", null, null, null, true)]
        [InlineData("NaN", null, null, null, true)]
        public void StringExtensions_ToShort(string value, short? defaultValue, bool? throwInsteadOfDefault, short? expected, bool? formatExceptionExpected)
        {
            if (throwInsteadOfDefault.HasValue && throwInsteadOfDefault.Value)
            {
                var ex = Assert.Throws<ArgumentException>(() => value.ToShort(throwInsteadOfDefault: throwInsteadOfDefault.Value));

                Assert.Equal($"The provided value '{value}' could not be converted to a short value becuase it is null, empty, or whitespace.", ex.Message);
                return;
            }

            if (formatExceptionExpected.HasValue && formatExceptionExpected.Value)
            {
                var ex = Assert.Throws<FormatException>(() => value.ToShort());

                Assert.Equal($"The provided value '{value}' could not be converted to a short value because it is not in the correct format.", ex.Message);
                return;
            }

            if (defaultValue.HasValue)
            {
                var result = value.ToShort(defaultValue: defaultValue.Value);

                Assert.Equal(expected, result);
            }
            else
            {
                var result = value.ToShort();

                Assert.Equal(expected, result);
            }            
        }

        [Theory]
        [InlineData(null, null, null, 0, null)]
        [InlineData("", null, null, 0, null)]
        [InlineData(" ", null, null, 0, null)]
        [InlineData(null, 1, null, 1, null)]
        [InlineData("", 1, null, 1, null)]
        [InlineData(" ", 1, null, 1, null)]
        [InlineData(null, null, true, 0, null)]
        [InlineData("", null, true, 0, null)]
        [InlineData(" ", null, true, 0, null)]
        [InlineData("1", null, null, 1, null)]
        [InlineData("-1", null, null, -1, null)]
        [InlineData("0", null, null, 0, null)]
        [InlineData("2147483647", null, null, int.MaxValue, null)]
        [InlineData("-2147483648", null, null, int.MinValue, null)]
        [InlineData("2147483648", null, null, null, true)]
        [InlineData("-2147483649", null, null, null, true)]
        [InlineData("NaN", null, null, null, true)]
        public void StringExtensions_ToInt(string value, int? defaultValue, bool? throwInsteadOfDefault, int? expected, bool? formatExceptionExpected)
        {
            if (throwInsteadOfDefault.HasValue && throwInsteadOfDefault.Value)
            {
                var ex = Assert.Throws<ArgumentException>(() => value.ToInt(throwInsteadOfDefault: throwInsteadOfDefault.Value));

                Assert.Equal($"The provided value '{value}' could not be converted to an int value becuase it is null, empty, or whitespace.", ex.Message);
                return;
            }

            if (formatExceptionExpected.HasValue && formatExceptionExpected.Value)
            {
                var ex = Assert.Throws<FormatException>(() => value.ToInt());

                Assert.Equal($"The provided value '{value}' could not be converted to an int value because it is not in the correct format.", ex.Message);
                return;
            }

            if (defaultValue.HasValue)
            {
                var result = value.ToInt(defaultValue: defaultValue.Value);

                Assert.Equal(expected, result);
            }
            else
            {
                var result = value.ToInt();

                Assert.Equal(expected, result);
            }
        }

        [Theory]
        [InlineData(null, null, null, 0, null)]
        [InlineData("", null, null, 0, null)]
        [InlineData(" ", null, null, 0, null)]
        [InlineData(null, 1, null, 1, null)]
        [InlineData("", 1, null, 1, null)]
        [InlineData(" ", 1, null, 1, null)]
        [InlineData(null, null, true, 0, null)]
        [InlineData("", null, true, 0, null)]
        [InlineData(" ", null, true, 0, null)]
        [InlineData("1", null, null, 1, null)]
        [InlineData("-1", null, null, -1, null)]
        [InlineData("0", null, null, 0, null)]
        [InlineData("9223372036854775807", null, null, long.MaxValue, null)]
        [InlineData("-9223372036854775808", null, null, long.MinValue, null)]
        [InlineData("9223372036854775808", null, null, null, true)]
        [InlineData("-9223372036854775809", null, null, null, true)]
        [InlineData("NaN", null, null, null, true)]
        public void StringExtensions_ToLong(string value, long? defaultValue, bool? throwInsteadOfDefault, long? expected, bool? formatExceptionExpected)
        {
            if (throwInsteadOfDefault.HasValue && throwInsteadOfDefault.Value)
            {
                var ex = Assert.Throws<ArgumentException>(() => value.ToLong(throwInsteadOfDefault: throwInsteadOfDefault.Value));

                Assert.Equal($"The provided value '{value}' could not be converted to a long value becuase it is null, empty, or whitespace.", ex.Message);
                return;
            }

            if (formatExceptionExpected.HasValue && formatExceptionExpected.Value)
            {
                var ex = Assert.Throws<FormatException>(() => value.ToLong());

                Assert.Equal($"The provided value '{value}' could not be converted to a long value because it is not in the correct format.", ex.Message);
                return;
            }

            if (defaultValue.HasValue)
            {
                var result = value.ToLong(defaultValue: defaultValue.Value);

                Assert.Equal(expected, result);
            }
            else
            {
                var result = value.ToLong();

                Assert.Equal(expected, result);
            }
        }
    }
}
