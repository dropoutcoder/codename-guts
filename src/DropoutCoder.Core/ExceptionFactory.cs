using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace DropoutCoder.Core {
    public static class ExceptionFactory {
        public static T Create<T>(IDictionary<string, object> args)
            where T : Exception, new() {
            T result = null;

            try {
                var typeInfo = TypeHelper
                    .GetTypeInfo<T>();

                var arguments = args
                    .Where(a => !Check.IsNullEmptyOrWhiteSpace(a.Key) && !Check.IsNull(a.Value));

                var constructors = typeInfo.DeclaredConstructors;

                var isMatch = constructors.Any(c =>
                                c.GetParameters()
                                    .Select(pi => new { Name = pi.Name, Type = pi.ParameterType })
                                    .SequenceEqual(
                                        arguments
                                            .Where(a => !Check.IsNull(a.Value))
                                            .Select(a => new { Name = a.Key, Type = a.Value.GetType() })));

                if (isMatch) {
                    var instance = Activator.CreateInstance(typeof(T), arguments
                        .Select(a => a.Value)
                        .ToArray()
                    );

                    result = (T)instance;
                }
            } catch (Exception e) {
#if DEBUG
                Debug.WriteLine(e);
#else
                Trace.TraceError(e);
#endif
            } finally {
                if (Check.IsNull(result)) {
                    result = new T();
                }
            }

            return result;
        }
    }
}
