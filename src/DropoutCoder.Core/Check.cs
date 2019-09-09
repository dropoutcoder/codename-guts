using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DropoutCoder.Core {
    /// <summary>
    /// Provides methods for type and value validation
    /// </summary>
    public abstract partial class Check {
        private Check() { }

        /// <summary>
        /// Indicates whether <paramref name="value"/> equals to type of <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of objects to compare.</typeparam>
        /// <param name="value">An object to compare with <typeparamref name="T"/></param>
        /// <returns>true if <paramref name="value"/> type if of type <typeparamref name="T"/>; otherwise, false.</returns>
        public static bool Is<T>(object value) {
            return value is T;
        }

        /// <summary>
        /// Indicates whether <paramref name="value"/> equals to <see langword="null" />.
        /// </summary>
        /// <typeparam name="T">The type of objects to compare.</typeparam>
        /// <param name="value">An object to compare with <see langword="null" /></param>
        /// <returns>true if <paramref name="value"/> is <see langword="null" />; otherwise, false.</returns>
        public static bool IsNull<T>(T value)
            where T : class {
            return value == null;
        }

        /// <summary>
        /// Indicates whether <paramref name="value"/> not equals to <see langword="null" />.
        /// </summary>
        /// <typeparam name="T">The type of objects to compare.</typeparam>
        /// <param name="value">An object to compare with <see langword="null" /></param>
        /// <returns>true if <paramref name="value"/> is not <see langword="null" />; otherwise, false.</returns>
        public static bool IsNotNull<T>(T value)
            where T : class {
            return !IsNull<T>(value);
        }
    }
}
