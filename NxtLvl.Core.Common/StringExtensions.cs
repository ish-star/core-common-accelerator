using System;

namespace NxtLvl.Core.Common.StringExtensions
{
    /// <summary>
    /// A class that contains extension methods for string values.  These methods provide string inspection and conversion capabilities.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Determines if the string value is null, empty, or whitespace.
        /// </summary>
        /// <param name="value">The string value to inspect.</param>
        /// <returns>True if the value is null, empty, or whitespce; otherwise False.</returns>
        public static bool IsNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        /// <summary>
        /// Converts the string value to a short value if possible.
        /// </summary>
        /// <param name="value">The string value to convert.</param>
        /// <param name="defaultValue">The default value if the value is null, empty, or whitespace.</param>
        /// <param name="throwInsteadOfDefault">Throw an exception instead of providing a default return if the value is null, empty, or whitespace.</param>
        /// <returns>The short value representation of the original string value.</returns>
        /// <exception cref="System.FormatException">Thrown when the string value cannot be converted into a short value.</exception>
        public static short ToShort(this string value, short defaultValue = 0, bool throwInsteadOfDefault = false)
        {
            if (value.IsNullOrWhiteSpace())
            {
                if (throwInsteadOfDefault)
                {
                    throw new ArgumentException($"The provided value '{value}' could not be converted to a short value becuase it is null, empty, or whitespace.");
                }

                return defaultValue;
            }

            short result;

            if (!short.TryParse(value, out result))
            {
                throw new FormatException($"The provided value '{value}' could not be converted to a short value because it is not in the correct format.");
            }

            return result;
        }

        /// <summary>
        /// Converts the string value to a int value if possible.
        /// </summary>
        /// <param name="value">The string value to convert.</param>
        /// <param name="defaultValue">The default value if the value is null, empty, or whitespace.</param>
        /// <param name="throwInsteadOfDefault">Throw an exception instead of providing a default return if the value is null, empty, or whitespace.</param>
        /// <returns>The int value representation of the original string value.</returns>
        /// <exception cref="System.FormatException">Thrown when the string value cannot be converted into a int value.</exception>
        public static int ToInt(this string value, int defaultValue = 0, bool throwInsteadOfDefault = false)
        {
            if (value.IsNullOrWhiteSpace())
            {
                if (throwInsteadOfDefault)
                {
                    throw new ArgumentException($"The provided value '{value}' could not be converted to an int value becuase it is null, empty, or whitespace.");
                }

                return defaultValue;
            }

            int result;

            if (!int.TryParse(value, out result))
            {
                throw new FormatException($"The provided value '{value}' could not be converted to an int value because it is not in the correct format.");
            }

            return result;
        }

        /// <summary>
        /// Converts the string value to a long value if possible.
        /// </summary>
        /// <param name="value">The string value to convert.</param>
        /// <param name="defaultValue">The default value if the value is null, empty, or whitespace.</param>
        /// <param name="throwInsteadOfDefault">Throw an exception instead of providing a default return if the value is null, empty, or whitespace.</param>
        /// <returns>The long value representation of the original string value.</returns>
        /// <exception cref="System.FormatException">Thrown when the string value cannot be converted into a long value.</exception>
        public static long ToLong(this string value, long defaultValue = 0, bool throwInsteadOfDefault = false)
        {
            if (value.IsNullOrWhiteSpace())
            {
                if (throwInsteadOfDefault)
                {
                    throw new ArgumentException($"The provided value '{value}' could not be converted to a long value becuase it is null, empty, or whitespace.");
                }

                return defaultValue;
            }

            long result;

            if (!long.TryParse(value, out result))
            {
                throw new FormatException($"The provided value '{value}' could not be converted to a long value because it is not in the correct format.");
            }

            return result;
        }

        /// <summary>
        /// Converts the string value to a decimal value if possible.
        /// </summary>
        /// <param name="value">The string value to convert.</param>
        /// <param name="defaultValue">The default value if the value is null, empty, or whitespace.</param>
        /// <param name="throwInsteadOfDefault">Throw an exception instead of providing a default return if the value is null, empty, or whitespace.</param>
        /// <returns>The long value representation of the original string value.</returns>
        /// <exception cref="System.FormatException">Thrown when the string value cannot be converted into a decimal value.</exception>
        public static decimal ToDecimal(this string value, decimal defaultValue = 0, bool throwInsteadOfDefault = false)
        {
            if (value.IsNullOrWhiteSpace())
            {
                if (throwInsteadOfDefault)
                {
                    throw new ArgumentException($"The provided value '{value}' could not be converted to a decimal value becuase it is null, empty, or whitespace.");
                }

                return defaultValue;
            }

            decimal result;

            if (!decimal.TryParse(value, out result))
            {
                throw new FormatException($"The provided value '{value}' could not be converted to a decimal value because it is not in the correct format.");
            }

            return result;
        }

        /// <summary>
        /// Converts the string value to a double value if possible.
        /// </summary>
        /// <param name="value">The string value to convert.</param>
        /// <param name="defaultValue">The default value if the value is null, empty, or whitespace.</param>
        /// <param name="throwInsteadOfDefault">Throw an exception instead of providing a default return if the value is null, empty, or whitespace.</param>
        /// <returns>The long value representation of the original string value.</returns>
        /// <exception cref="System.FormatException">Thrown when the string value cannot be converted into a double value.</exception>
        public static double ToDouble(this string value, double defaultValue = 0, bool throwInsteadOfDefault = false)
        {
            if (value.IsNullOrWhiteSpace())
            {
                if (throwInsteadOfDefault)
                {
                    throw new ArgumentException($"The provided value '{value}' could not be converted to a double value becuase it is null, empty, or whitespace.");
                }

                return defaultValue;
            }

            double result;

            if (!double.TryParse(value, out result))
            {
                throw new FormatException($"The provided value '{value}' could not be converted to a double value because it is not in the correct format.");
            }

            return result;
        }
    }
}