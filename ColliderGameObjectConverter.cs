using UnityEngine;

namespace Plugins.MonoConverters {
	[AddComponentMenu("MonoConverters/(Collider) => GameObject")]
	public class ColliderGameObjectConverter : BaseMonoConverter<Collider, GameObject> {
		protected override GameObject Inner_Convert(Collider entryValue) {
			return entryValue.gameObject;
			
		}
	}
}