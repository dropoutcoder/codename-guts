using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DropoutCoder.Core {
    /// <summary>
    /// Provides methods for common type and value validation
    /// </summary>
    public partial class Check {
        private Check() { }

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
        /// Indicates whether <paramref name="value"/> equals to type of <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of objects to compare.</typeparam>
        /// <param name="value">An object to compare with <typeparamref name="T"/></param>
        /// <returns>true if <paramref name="value"/> type if of type <typeparamref name="T"/>; otherwise, false.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Is<T>(object value) {
            return value is T;
        }

        /// <summary>
        /// Indicates whether <paramref name="value"/> equals to <see langword="null" />.
        /// </summary>
        /// <typeparam name="T">The type of objects to compare.</typeparam>
        /// <param name="value">An object to compare with <see langword="null" /></param>
        /// <returns>true if <paramref name="value"/> is <see langword="null" />; otherwise, false.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNull<T>(T value) {
            return value == null;
        }

        /// <summary>
        /// Indicates whether <paramref name="value"/> equals to <see langword="default" />.
        /// </summary>
        /// <typeparam name="T">The type of objects to compare.</typeparam>
        /// <param name="value">An object to compare with <see langword="default" /></param>
        /// <returns>true if <paramref name="value"/> is <see langword="default" />; otherwise, false.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsDefault<T>(ref T value)
            where T : struct, IEquatable<T> {
            return value.Equals(default);
        }

        /// <summary>
        /// Indicates whether <paramref name="value"/> equals to <see langword="default" />.
        /// </summary>
        /// <typeparam name="T">The type of objects to compare.</typeparam>
        /// <param name="value">An object to compare with <see langword="default" /></param>
        /// <returns>true if <paramref name="value"/> is <see langword="default" />; otherwise, false.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsDefault<T>(ref T? value)
            where T : struct, IEquatable<T> {
            if (!value.HasValue) {
                return true;
            }

            T temp = value.Value;

            return IsDefault(ref temp);
        }
    }
}
