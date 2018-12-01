using NxtLvl.Core.Common.StringExtensions;
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
    }
}
