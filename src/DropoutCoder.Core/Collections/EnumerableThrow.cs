using System;
using System.Collections.Generic;
using DropoutCoder.Core.Extensions;

namespace DropoutCoder.Core {
    public partial class Throw {
        public static void IfNullOrEmpty<T>(IEnumerable<T> value, string parameName = null, string message = null) {
            if (Check.IsNull(value)) {
                ExceptionFactory.Create<ArgumentNullException>(new { message, parameName }.ToDictionary());
            }

            if (Check.IsNullOrEmpty(value)) {
                ExceptionFactory.Create<ArgumentException>(new { message, parameName }.ToDictionary());
            }
        }
    }
}
