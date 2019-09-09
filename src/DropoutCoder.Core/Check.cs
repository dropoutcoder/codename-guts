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
    }
}
