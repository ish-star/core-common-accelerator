using System;
using NxtLvl.Core.Common.StringExtensions;

namespace NxtLvl.Core.Common
{
    public static class Validate
    {
        public static void ArgumentIsNotNull<TArgument>(TArgument argument, string nameof)
            where TArgument : class
        {
            if (argument == null)
            {
                throw new ArgumentNullException(nameof);
            }
        }

        public static void ArgumentIsNotNullOrEmpty(string argument, string nameof)
        {
            if (argument.IsNullOrWhiteSpace())
            {
                throw new ArgumentException($"Value cannot be null or whitespace.{Environment.NewLine}Parameter name: {nameof}");
            }
        }
    }
}