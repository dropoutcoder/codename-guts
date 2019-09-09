using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DropoutCoder.Core;

namespace DropoutCoder.Core.Extensions {
    public static class ObjectExtensions {
        private static ConcurrentDictionary<TypeInfo, IEnumerable<PropertyInfo>> _typeInfoCache = new ConcurrentDictionary<TypeInfo, IEnumerable<PropertyInfo>>();
        public static IDictionary<string, object> ToDictionary(this object source) {
            Throw.IfNull(source, paramName: nameof(source));

            var typeInfo = source
                    .GetType()
                    .GetTypeInfo();

            IEnumerable<PropertyInfo> properties;

            if (Check.IsAnonymousType(source) ?? false) {
                properties = typeInfo
                    .DeclaredProperties
                    .Where(p => p.CanRead);
            } else {
                var isInCache = Check.ContainsKey(_typeInfoCache, typeInfo);
                var isLoaded = _typeInfoCache.TryGetValue(typeInfo, out properties);

                if (!isInCache || !isLoaded) {
                    properties = typeInfo
                        .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                        .Where(p => p.CanRead);

                    _ = _typeInfoCache.TryAdd(typeInfo, properties);
                }
            }

            return properties
                .ToDictionary(p => p.Name, p => p.GetValue(source));
        }
    }
}
