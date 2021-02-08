using UnityAtoms.MonoHooks;
using UnityEngine;

namespace Plugins.MonoConverters {
	[AddComponentMenu("MonoConverters/(ColliderGameObject) => GameObject")]
	public class ColliderGameObjectToGameObjectConverter : BaseMonoConverter<ColliderGameObject, GameObject> {
		protected override GameObject Inner_Convert(ColliderGameObject entryValue) {
			return entryValue.GameObject;
		}
	}
}