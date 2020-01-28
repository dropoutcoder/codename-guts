namespace DropoutCoder.Core {
	using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public partial class Check {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ContainsKey<TKey, TValue>(IDictionary<TKey, TValue> dictionary, TKey key) {
			Throw.IfNull(dictionary);
			Throw.IfNull(key);

			return dictionary.ContainsKey(key);
		}
    }
}
