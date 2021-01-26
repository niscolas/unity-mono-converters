namespace Plugins.MonoConverters {
	public class IntFloatConverter : BaseMonoConverter<int, float> {
		protected override float Inner_Convert(int entryValue) {
			return entryValue;
		}
	}
}