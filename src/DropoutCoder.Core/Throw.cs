using System.ComponentModel;

namespace DropoutCoder.Core {
    /// <summary>
    /// Provides methods for common validation and throwing exception if validation didn't pass
    /// </summary>
    public abstract partial class Throw {
        private Throw() { }


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
    }
}
