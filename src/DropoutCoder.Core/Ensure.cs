using System.ComponentModel;

namespace DropoutCoder.Core {
    /// <summary>
    /// Provides methods for ensuring objects are initialized
    /// </summary>
    public sealed partial class Ensure {
        private Ensure() { }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) {
            return base.Equals(obj);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() {
            return base.GetHashCode();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString() {
            return base.ToString();
        }

        /// <summary>
        /// Ensures <paramref name="value"/> is initialized type of <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The type of <paramref name="value"/>.</typeparam>
        /// <param name="value">An object to be initialized if not already</param>
        public static void IsNotNull<T>(ref T value)
            where T : class, new() {
            if(Check.IsNull(value)) {
                value = new T();
            }
        }
    }
}
