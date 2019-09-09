namespace DropoutCoder.Core {
	using System.Collections.Generic;

	public partial class Check {
		public static bool ContainsKey<TKey, TValue>(IDictionary<TKey, TValue> dictionary, TKey key) {
			Throw.IfNull(dictionary);
			Throw.IfNull(key);

			return dictionary.ContainsKey(key);
		}
    }
}
