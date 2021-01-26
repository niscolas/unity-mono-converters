namespace Plugins.MonoConverters {
	public class IntFloatConverter : BaseValueConverter<int, float> {
		protected override float Inner_Convert(int value) {
			return value;
		}
	}
}