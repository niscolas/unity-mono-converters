using System.Globalization;

namespace Plugins.MonoConverters {
	public class FloatStringConverter : BaseMonoConverter<float, string> {
		protected override string Inner_Convert(float entryValue) {
			return entryValue.ToString(CultureInfo.InvariantCulture);
		}
	}
}