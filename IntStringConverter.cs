namespace Plugins.MonoConverters {
	public class IntStringConverter : BaseValueConverter<int, string> {
		protected override string Inner_Convert(int value) {
			return value.ToString();
		}
	}
}