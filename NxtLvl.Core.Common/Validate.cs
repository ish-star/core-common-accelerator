using System;
using NxtLvl.Core.Common.StringExtensions;

namespace NxtLvl.Core.Common
{
    /// <summary>
    /// A class that contains method to validate arguments and properties meet certain expectations.
    /// </summary>
    public static class Validate
    {
        /// <summary>
        /// Validates the argument parameter is not null.
        /// </summary>
        /// <typeparam name="TArgument">The type of the argument to validate.</typeparam>
        /// <param name="argument">The argument to validate.</param>
        /// <param name="nameof">The name of the argument to validate.</param>
        /// <exception cref="System.ArgumentNullException">Thrown when the argument is null.</exception>
        public static void ArgumentIsNotNull<TArgument>(TArgument argument, string nameof)
            where TArgument : class
        {
            if (argument == null)
            {
                throw new ArgumentNullException(nameof);
            }
        }

        /// <summary>
        /// Validates the property parameter is not null.
        /// </summary>
        /// <typeparam name="TNullableProperty">The type of the property to validate.</typeparam>
        /// <param name="property">The property to validate.</param>
        /// <param name="nameof">The name of the property to validate</param>
        /// <exception cref="System.ArgumentException">Thrown when the property is null.</exception>
        public static void PropertyHasValue<TNullableProperty>(TNullableProperty property, string nameof)
        {
            if (property == null)
            {
                throw new ArgumentException($"Value cannot be null.{Environment.NewLine}Property name: {nameof}");
            }
        }

        /// <summary>
        /// Validates the argument parameter is not null or whitespace.
        /// </summary>
        /// <param name="argument">The argument to validate.</param>
        /// <param name="nameof">The name of the argument to validate.</param>
        /// <exception cref="System.ArgumentException">Thrown when the argument is null, empty, or whitespace.</exception>
        public static void ArgumentIsNotNullOrEmpty(string argument, string nameof)
        {
            if (argument.IsNullOrWhiteSpace())
            {
                throw new ArgumentException($"Value cannot be null or whitespace.{Environment.NewLine}Parameter name: {nameof}");
            }
        }
    }
}