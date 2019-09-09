using System.Collections;
using System.Collections.Generic;

namespace DropoutCoder.Core {
	public partial class Check {
        /// <summary>
        /// Provides a way to check if supplied enumerable value is null or empty
        /// </summary>
        /// <param name="value">Enumerable value to check against</param>
        /// <returns>Returns boolean value indicates result of the check</returns>
        public static bool IsNullOrEmpty(IEnumerable value) {
            return Check.IsNull(value) ? true : !value.GetEnumerator().MoveNext();
        }

        /// <summary>
        /// Provides a way to check if supplied enumerable value is null or empty
        /// </summary>
        /// <param name="value">Enumerable value to check against</param>
        /// <returns>Returns boolean value indicates result of the check</returns>
        public static bool IsNullOrEmpty<T>(IEnumerable<T> value) {
            return Check.IsNull(value) ? true : !value.GetEnumerator().MoveNext();
        }
    }
}
