using System;
using DropoutCoder.Core.Extensions;
using DropoutCoder.Core.Resources;

namespace DropoutCoder.Core {
    public partial class Throw {
        /// <summary>
		/// Check if supplied boolean value is true
		/// </summary>
		/// <param name="value">Value to check condition against</param>
		/// <exception cref="ArgumentException">Value is true</exception>
		public static void IfTrue(bool value) {
            if (Check.IsTrue(value)) {
                throw ExceptionFactory.Create<ArgumentException>(new { paramName = nameof(value), message = ExceptionMessageResources.ValueCannotBeTrue }.ToDictionary());
            }
        }

        /// <summary>
		/// Check if supplied boolean value is false
		/// </summary>
		/// <param name="value">Value to check condition against</param>
		/// <exception cref="ArgumentException">Value is false</exception>
		public static void IfFalse(bool value) {
            if (Check.IsFalse(value)) {
                throw ExceptionFactory.Create<ArgumentException>(new { paramName = nameof(value), message = ExceptionMessageResources.ValueCannotBeFalse }.ToDictionary());
            }
        }
    }
}
