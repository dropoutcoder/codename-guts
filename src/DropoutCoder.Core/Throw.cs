using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DropoutCoder.Core {
    /// <summary>
    /// Provides methods for common validation and throwing exception if validation didn't pass
    /// </summary>
    public sealed partial class Throw {
        private Throw() { }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) {
            return base.Equals(obj);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() {
            return base.GetHashCode();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString() {
            return base.ToString();
        }

        /// <summary>
        /// Determines whether the specified object is null. If result of comparison is true then exception is trown.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"></exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IfNull<T>(T value, string paramName = null, string message = null) {
            if (Check.IsNull(value)) {
                throw ExceptionFactory.Create<ArgumentNullException>(new { paramName = paramName ?? nameof(value), message = message }.ToDictionary());
            }
        }

        /// <summary>
        /// Determines whether the specified object is null. If result of comparison is true then exception is trown.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"></exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IfDefault<T>(ref T value, string paramName = null, string message = null)
            where T : struct, IEquatable<T> {
            if (Check.IsDefault(ref value)) {
                throw ExceptionFactory.Create<ArgumentException>(new { paramName = paramName ?? nameof(value), message = message }.ToDictionary());
            }
        }
    }
}
