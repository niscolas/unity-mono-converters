using UnityEngine;
using UnityEngine.Events;

namespace Plugins.MonoConverters {
	public abstract class BaseMonoConverter<TEntry, TExit> : MonoBehaviour {
		[SerializeField]
		private UnityEvent<TExit> onConverted;

		protected abstract TExit Inner_Convert(TEntry entryValue);

		public void Convert(TEntry entryValue) {
			if (entryValue == null) {
				Debug.LogWarning("Post conversion value was null");
				return;
			}

			onConverted?.Invoke(Inner_Convert(entryValue));
		}
	}
}