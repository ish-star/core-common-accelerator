using System;
using Xunit;

namespace NxtLvl.Core.Common.Tests
{
    public class ValidateTests
    {
        [Theory]
        [InlineData(false, true)]
        [InlineData(true, false)]
        public void Validate_ArgumentIsNotNull(bool initializeObject, bool exceptionExpected)
        {
            object testArgument = initializeObject ? new object() : null;

            if (exceptionExpected)
            {
                var ex = Assert.Throws<ArgumentNullException>(() => Validate.ArgumentIsNotNull(testArgument, nameof(testArgument)));

                Assert.Equal("Value cannot be null.\r\nParameter name: testArgument", ex.Message);
                return;
            }

            Validate.ArgumentIsNotNull(testArgument, nameof(testArgument));
        }

        [Theory]
        [InlineData(null, true)]
        [InlineData("", true)]
        [InlineData(" ", true)]
        [InlineData("val", false)]
        public void Validate_ArgumentIsNotNullOrWhiteSpace(string testArgument, bool exceptionExpected)
        {
            if (exceptionExpected)
            {
                var ex = Assert.Throws<ArgumentException>(() => Validate.ArgumentIsNotNullOrEmpty(testArgument, nameof(testArgument)));

                Assert.Equal("Value cannot be null or whitespace.\r\nParameter name: testArgument", ex.Message);
                return;
            }

            Validate.ArgumentIsNotNullOrEmpty(testArgument, nameof(testArgument));
        }
    }
}
