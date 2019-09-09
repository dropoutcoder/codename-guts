using System;

using DropoutCoder.Core.Extensions;
using DropoutCoder.Core.Resources;

namespace DropoutCoder.Core {
    public partial class Throw {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static void IfNullEmptyOrWhiteSpace(string value, string message = null, string paramName = null) {
            if (Check.IsNullEmptyOrWhiteSpace(value)) {
                throw ExceptionFactory.Create<ArgumentException>(new { message = message ?? ExceptionMessageResources.ValueCannotBeNullEmptyOrWhiteSpace, paramName = paramName ?? nameof(value) }.ToDictionary());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static void IfNullOrEmpty(string value, string message = null, string paramName = null) {
            if (Check.IsNullOrEmpty(value)) {
                throw ExceptionFactory.Create<ArgumentException>(new { paramName = paramName ?? nameof(value), message = message ?? ExceptionMessageResources.ValueCannotBeNullOrEmpty }.ToDictionary());
            }
        }
    }
}
