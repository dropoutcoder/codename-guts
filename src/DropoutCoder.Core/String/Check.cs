using System;
using System.Text.RegularExpressions;
using DropoutCoder.Core.RegularExpression;
using DropoutCoder.Core.Resources;

namespace DropoutCoder.Core {
    public partial class Check {
        /// <summary>
        /// Provides a way to check if supplied string value is null, empty or whitespace
        /// </summary>
        /// <param name="value">String value to check against</param>
        /// <returns>Returns boolean value indicates result of the check</returns>
        public static bool IsNullEmptyOrWhiteSpace(string value) {
            return String.IsNullOrWhiteSpace(value);
        }

        /// <summary>
        /// Provides a way to check if supplied string value has requested length
        /// </summary>
        /// <param name="value">String value to check against</param>
        /// <param name="length">Int value indicating lenght to check against</param>
        /// <returns>Returns boolean value indicates result of the check</returns>
        public static bool HasLength(string value, ref int length) {
            Throw.IfNull(value, message: ExceptionMessageResources.ValueCannotBeNull);

            return value.Length == length;
        }

        /// <summary>
        /// Provides a way to check if supplied string value contains white space
        /// </summary>
        /// <param name="value">String value to check against</param>
        /// <returns>Returns boolean value indicates result of the check</returns>
        public static bool HasWhiteSpace(string value) {
            Throw.IfNull(value, message: ExceptionMessageResources.ValueCannotBeNull);

            return Check.IsMatch(value, Patterns.OneOrMoreWhiteSpace);
        }

        /// <summary>
        /// Provides a way to check if supplied string value contains diacritics
        /// </summary>
        /// <param name="value">String value to check against</param>
        /// <returns>Returns boolean value indicates result of the check</returns>
        public static bool HasDiacritics(string value) {
            Throw.IfNull(value, message: ExceptionMessageResources.ValueCannotBeNull);

            var nonDiacritics = Check.IsMatch(value, Patterns.NonDiacritics);
            var anyLetter = Check.IsMatch(value, Patterns.AnyLetter);

            return !nonDiacritics && anyLetter;
        }

        /// <summary>
        /// Provides a way to check if supplied string value is email address
        /// </summary>
        /// <param name="value">String value to check against</param>
        /// <returns>Returns boolean value indicates result of the check</returns>
        public static bool IsEmail(string value) {
            Throw.IfNull(value, message: ExceptionMessageResources.ValueCannotBeNull);

            return Check.IsMatch(value, Patterns.Email);
        }

        /// <summary>
        /// Provides a way to check if supplied string value match regular expression pattern
        /// </summary>
        /// <param name="value">String value to check against</param>
        /// <param name="pattern">String value of regular expreesion pattern to match against</param>
        /// <returns>Returns boolean value indicates result of the check</returns>
        public static bool IsMatch(string value, string pattern) {
            Throw.IfNull(value, message: ExceptionMessageResources.ValueCannotBeNull);
            Throw.IfNull(pattern, nameof(pattern), ExceptionMessageResources.ValueCannotBeNull);

            return new Regex(pattern).IsMatch(value);
        }
    }
}
