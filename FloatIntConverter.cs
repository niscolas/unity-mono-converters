namespace Plugins.MonoConverters {
	public class FloatINtConverter : BaseValueConverter<float, int> {
		protected override int Inner_Convert(float value) {
			return (int) value;
		}
	}
}