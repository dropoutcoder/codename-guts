using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Type GetType<T>() {
            return typeof(T);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TypeInfo GetTypeInfo<T>() {
            return GetType<T>().GetTypeInfo();
        }
    }
}
