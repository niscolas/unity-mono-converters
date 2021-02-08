using UnityAtoms;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Plugins.MonoConverters {
	public abstract class BaseMonoConverter<TEntry, TExit> : MonoBehaviour {
		[FormerlySerializedAs("selectGameObjectFunction")]
		[SerializeField]
		private AtomFunction<TExit, TExit> filterExitFunc;
		
		[Space]
		[SerializeField]
		private AtomCondition<TExit>[] conditions;

		[Header("Events")]
		[SerializeField]
		private UnityEvent<TExit> onConverted;

		protected abstract TExit Inner_Convert(TEntry entryValue);

		public void Convert(TEntry entryValue) {
			if (entryValue == null) {
				Debug.LogWarning("Post conversion value was null");
				return;
			}

			TExit exitValue = Inner_Convert(entryValue);

			if (filterExitFunc) {
				exitValue = filterExitFunc.Call(exitValue);
			}

			foreach (AtomCondition<TExit> condition in conditions) {
				if (!condition.Call(exitValue)) {
					return;
				}
			}

			onConverted?.Invoke(exitValue);
		}
	}
}