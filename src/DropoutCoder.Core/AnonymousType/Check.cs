using System.Reflection;
using System.Runtime.CompilerServices;

namespace DropoutCoder.Core {
    public partial class Check {
        /// <summary>
        /// Indicates whether <paramref name="value"/> is compiler generated anonymous type.
        /// </summary>
        /// <param name="value">An object to evaluate.</param>
        /// <returns><see langword="null"/> if passed parameter is <see langword="null"/>; <see langword="true"/> if type is compiler generated and name starts with AnonymousType; otherwise false.</returns>
        public static bool? IsAnonymousType(object value) {
            bool? result = null;

            if (!IsNull(value)) {
                var typeInfo = value
                    .GetType()
                    .GetTypeInfo();

                var isCompilerGenerated = typeInfo.GetCustomAttribute<CompilerGeneratedAttribute>(false) != null;
                var nameStartsWithAnonymousType = typeInfo.Name.StartsWith("AnonymousType");

                result = isCompilerGenerated && nameStartsWithAnonymousType;
            }

            return result;
        }
    }
}
