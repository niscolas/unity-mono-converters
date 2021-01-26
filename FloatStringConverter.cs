using System.Globalization;

namespace Plugins.MonoConverters {
	public class FloatStringConverter : BaseValueConverter<float, string> {
		protected override string Inner_Convert(float value) {
			return value.ToString(CultureInfo.InvariantCulture);
		}
	}
}