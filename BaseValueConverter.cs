using UnityEngine;
using UnityEngine.Events;

namespace Plugins.MonoConverters {
	public abstract class BaseValueConverter<TB, TT> : MonoBehaviour {
		[SerializeField]
		private UnityEvent<TT> onConverted;

		protected abstract TT Inner_Convert(TB value);

		public void Convert(TB value) {
			if (value == null) {
				Debug.LogWarning("Post conversion value was null");
				return;
			}

			onConverted?.Invoke(Inner_Convert(value));
		}
	}
}