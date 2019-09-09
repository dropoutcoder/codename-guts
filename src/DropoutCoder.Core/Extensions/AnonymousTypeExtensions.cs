namespace DropoutCoder.Core.Extensions {
	using System.Collections.Generic;
	using System.Linq;
	using System.Reflection;
	using DropoutCoder.Core;

	public static class AnonymousTypeExtensions {
		public static IDictionary<string, object> ToDictionary(this object source) {
			Throw.IfNull(source, paramName: nameof(source));

			IDictionary<string, object> result = null;

			if (Check.IsAnonymousType(source) ?? false) {
				var typeInfo = source
                    .GetType()
                    .GetTypeInfo();

				var properties = typeInfo
                    .DeclaredProperties
                    .Where(p => p.CanRead);

				result = properties
                    .ToDictionary<PropertyInfo, string, object>(p => p.Name, p => p.GetValue(source));
			}

			return result ?? new Dictionary<string,object>();
		}
	}
}
