﻿namespace DropoutCoder.Core {
	using System;
	using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using DropoutCoder.Core.Extensions;
    using DropoutCoder.Core.Resources;

    public partial class Throw {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void IfContainsKey<TKey, TValue>(IDictionary<TKey, TValue> dictionary, TKey key) {
			if(Check.ContainsKey(dictionary, key)) {
				ExceptionFactory.Create<InvalidOperationException>(new { message = ExceptionMessageResources.DictionaryContainsKey }.ToDictionary());
			}
		}
	}
}
