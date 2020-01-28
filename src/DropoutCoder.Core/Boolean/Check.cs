using System.Runtime.CompilerServices;

namespace DropoutCoder.Core {
    public partial class Check {
        /// <summary>
        /// Provides a way to check if supplied boolean value is true
        /// </summary>
        /// <param name="value">Boolean value to check against</param>
        /// <returns>Returns itself</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsTrue(bool value) {
            return value;
        }

        /// <summary>
        /// Provides a way to check if supplied boolean value is false
        /// </summary>
        /// <param name="value">Boolean value to check against</param>
        /// <returns>Returns negated itself</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsFalse(bool value) {
            return !IsTrue(value);
        }
    }
}
