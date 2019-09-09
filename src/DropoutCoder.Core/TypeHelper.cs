using System;
using System.Collections.Generic;
using System.Reflection;

namespace DropoutCoder.Core {
    public static class TypeHelper {
        public static readonly IEnumerable<Type> BuiltInTypes = new[] {
                GetType<bool>(),
                GetType<byte>(),
                GetType<sbyte>(),
                GetType<char>(),
                GetType<decimal>(),
                GetType<double>(),
                GetType<float>(),
                GetType<int>(),
                GetType<uint>(),
                GetType<long>(),
                GetType<ulong>(),
                GetType<object>(),
                GetType<short>(),
                GetType<string>()
        };

        public static Type GetType<T>() {
            return typeof(T);
        }

        public static TypeInfo GetTypeInfo<T>() {
            return GetType<T>().GetTypeInfo();
        }
    }
}
